using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour {

	[SerializeField] float xRotationsPerMinute = 1f;
	[SerializeField] float yRotationsPerMinute = 1f;
	[SerializeField] float zRotationsPerMinute = 1f;
	
	// Update is called once per frame
	void Update () {
		// seconds frame^-1, degrees rotation^-1, seconds minute^-1, rotation minute^-1
		float xDegreesPerFrame = Time.deltaTime * 360 * xRotationsPerMinute / 60;
		transform.RotateAround (transform.position, transform.right, xDegreesPerFrame);

		float yDegreesPerFrame = Time.deltaTime * 360 * yRotationsPerMinute / 60;
		transform.RotateAround (transform.position, transform.up, yDegreesPerFrame);

		float zDegreesPerFrame = Time.deltaTime * 360 * zRotationsPerMinute / 60;
		transform.RotateAround (transform.position, transform.forward, zDegreesPerFrame);

	}
}
