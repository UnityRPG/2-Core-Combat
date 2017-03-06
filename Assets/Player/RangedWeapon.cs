using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour {

	[SerializeField] GameObject projectilePrefab = null;
	[SerializeField] float timeBetweenShots = 0.5f;
	[SerializeField] float projectileSpeed = 10f;
	[SerializeField] float aimHeightAboveFeet = 1f;

	float lastShotTime = 0f;
	CameraRaycaster cameraRaycaster;
	Player player;

	// Use this for initialization
	void Start () {
		cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
		player = GameObject.FindObjectOfType<Player>();
	}

	void OnMouseClicked(RaycastHit hit, int layerHit)
	{
		if (layerHit == 9 && (Time.time - lastShotTime) > timeBetweenShots)
		{
			FireProjectile (hit.collider.gameObject);
			lastShotTime = Time.time;
		}
	}

	void FireProjectile (GameObject target)
	{
		GameObject projectile = Instantiate (projectilePrefab, transform.position, Quaternion.identity);
		projectile.transform.parent = gameObject.transform;
		Vector3 aimAdjust = new Vector3 (0, aimHeightAboveFeet, 0);
		Vector3 velocity = (target.transform.position + aimAdjust - transform.position).normalized * projectileSpeed;
		projectile.GetComponent<Rigidbody>().velocity = velocity;
	}
}
