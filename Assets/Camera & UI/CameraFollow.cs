using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField] GameObject gameCanvasPrefab = null;
	[SerializeField] GameObject eventSystemPrefab = null;

	GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
		Instantiate (gameCanvasPrefab);
		Instantiate (eventSystemPrefab);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position;
	}
}
