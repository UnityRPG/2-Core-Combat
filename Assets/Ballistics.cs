using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistics : MonoBehaviour {

	[SerializeField] GameObject projectilePrefab = null;
	[SerializeField] float timeBetweenShots = 0.5f;

	float lastShotTime = 0f;
	CameraRaycaster cameraRaycaster;

	// Use this for initialization
	void Start () {
		cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
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
		var initialRotation = Quaternion.Euler (new Vector3 (90, 0, 0));
		var projectile = Instantiate (projectilePrefab, transform.position, initialRotation);

	}
}
