using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    Coroutine myHandle = null;

	// Use this for initialization
	void Start () {
        var coRoutineHandle = StartCoroutine(LazyRepeatPrint(0.5f));
        StartCoroutine(CancelAfterSeconds(5f, coRoutineHandle));
	}

    IEnumerator CancelAfterSeconds(float time, Coroutine handle)
    {
        yield return new WaitForSeconds(time);
        StopCoroutine(handle);
    }

    IEnumerator LazyRepeatPrint(float timeBetween)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetween);
            print("Printed repeating");
        }
    }
}
