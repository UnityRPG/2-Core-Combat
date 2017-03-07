using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    Coroutine myHandle = null;

	// Use this for initialization
	void Start () {
        myHandle = this.InvokeRepeating(Donkey, 1f, 1f);
        this.Invoke(CancelMe, 5f);
	}

    void CancelMe() {
        StopCoroutine(myHandle);
    }

    void Donkey() {
        print("lksadf");
    }
}
