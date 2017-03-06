using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour {
	public static bool isStandingAndDelivering = false;

	[SerializeField] GameObject projectilePrefab = null;
	[SerializeField] float timeBetweenShots = 0.5f;
	[SerializeField] float projectileSpeed = 10f;
	[SerializeField] float aimHeightAboveFeet = 1f;
	[SerializeField] float rightTriggerFireThreshold = 0.8f;
	[SerializeField] GameObject projectileParent = null;

	float lastShotTime = 0f;
	CameraRaycaster cameraRaycaster;
	Player player;

	// Use this for initialization
	void Start () {
		cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
		player = FindObjectOfType<Player>();
	}

	void Update()
	{
		if (Input.GetAxis ("Right Trigger") > rightTriggerFireThreshold)
		{
			FireProjectile (player.GetForwardDirection ());
			isStandingAndDelivering = true;
		}
		else
		{
			isStandingAndDelivering = false;
		}

	}

	void OnMouseClicked(RaycastHit hit, int layerHit)
	{
		if (layerHit == 9)
		{
			FireProjectile (hit.collider.gameObject.transform.position);
		}
	}

	void FireProjectile (Vector3 target)
	{
		if (Time.time - lastShotTime > timeBetweenShots)
		{
			GameObject projectile = Instantiate (projectilePrefab, transform.position, Quaternion.identity);
			projectile.transform.parent = projectileParent.transform;
			Vector3 aimAdjust = new Vector3 (0, aimHeightAboveFeet, 0);
			Vector3 velocity = (target + aimAdjust - transform.position).normalized * projectileSpeed;
			projectile.GetComponent<Rigidbody>().velocity = velocity;
			lastShotTime = Time.time;
		}
	}
}
