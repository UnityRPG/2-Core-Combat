using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour {
	public static bool isFiring = false; // move to Player member with getter

	[SerializeField] GameObject projectilePrefab = null;
	[SerializeField] float timeBetweenShots = 0.5f;
	[SerializeField] float projectileSpeed = 10f;
	[SerializeField] float aimHeightAboveFeet = 1f;
	[SerializeField] float rightTriggerFireThreshold = 0.8f;
    [SerializeField] float aimStickThreshold = 0.2f;

	[SerializeField] 
	[Range(0.1f, 1f)]
	[Tooltip("Size of virtual ball fired out looking for enemies")]
	float sphereCastRadius = 0.5f;

	[SerializeField] float sphereCastMaxDist = 20f;

	Enemy closestEnemy = null;
    float lastShotTime = 0f;
	CameraRaycaster cameraRaycaster;
	Vector3 aimDirection;
	GameObject dynamicObjectsParent = null;

	// Use this for initialization
	void Start () {
		cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
		dynamicObjectsParent = new GameObject("DynamicObjects"); // consider singleton
	}

	void Update()
	{
		// XBox 360 controller is "6th Axis"
        if (Input.GetAxis ("Right Trigger") > rightTriggerFireThreshold)
		{
			isFiring = true;
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");

			Vector3 cameraForward = Vector3.Scale (Camera.main.transform.forward, new Vector3 (1, 0, 1)).normalized;
			aimDirection = v * cameraForward + h * Camera.main.transform.right; // TODO make remember last aim

            if (Mathf.Abs(h) > aimStickThreshold || Mathf.Abs(v) > aimStickThreshold)
            {
                transform.rotation = Quaternion.LookRotation(aimDirection); // Create rotation animator parameter
				if (SetClosestEnemy())
				{
					var fireDirection = closestEnemy.transform.position - transform.position;
					FireProjectile (fireDirection);
					closestEnemy.Highlight (true);
				}
				else
				{
					FireProjectile (transform.forward);
					closestEnemy.Highlight (false);
				}
            }
        }
		else
		{
			isFiring = false;
		}
	}

	bool SetClosestEnemy()
	{
		RaycastHit hitInfo; // as out parameter
		var hit = Physics.SphereCast (
			transform.position,
			sphereCastRadius,
			transform.forward,
			out hitInfo,
			sphereCastMaxDist,
			LayerMask.GetMask ("Enemy")
		);
			
		if (hit)
		{
			closestEnemy = hitInfo.collider.gameObject.GetComponent<Enemy> (); // TODO beware Law of Demeter
			return true;
		} 
		else
		{
			return false;
		}
	}

	void OnMouseClicked(RaycastHit hit, int layerHit)
	{
		if (layerHit == 9)
		{
			Vector3 aimAdjust = new Vector3 (0, aimHeightAboveFeet, 0);
			Vector3 target = hit.collider.gameObject.transform.position;
			Vector3 velocity = (target + aimAdjust - transform.position).normalized * projectileSpeed;
			FireProjectile (velocity);
		}
	}

	void FireProjectile (Vector3 velocity)
	{
		if (Time.time - lastShotTime > timeBetweenShots)
		{
			GameObject projectile = Instantiate (projectilePrefab, transform.position, Quaternion.identity);
			projectile.transform.parent = dynamicObjectsParent.transform; 	 
			projectile.GetComponent<Rigidbody>().velocity = velocity.normalized * projectileSpeed;
			lastShotTime = Time.time;
		}
	}

	void OnDrawGizmos()
	{
		if (isFiring)
		{
			Gizmos.color = Color.red;
			Gizmos.matrix = transform.localToWorldMatrix;
			Gizmos.DrawFrustum (Vector3.zero, 10f, 20f, 1f, 1f);
		}
	}
}
