using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Weapon ready");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter()
    { print("Boom"); }

    void OnTriggerEnter()
    { print("Trigger"); }
}
