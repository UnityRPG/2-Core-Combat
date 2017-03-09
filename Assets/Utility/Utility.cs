using System;
using System.Collections;
using UnityEngine;

public static class Utility
{
    // Replace Unity's built-in string-referenced Invoke
    public static Coroutine Invoke(this MonoBehaviour monoBehaviour, Action action, float delay)
    {
        return monoBehaviour.StartCoroutine(InvokeImpl(action, delay));
    }

    private static IEnumerator InvokeImpl(Action action, float time)
    {
        yield return new WaitForSeconds(time);
        action();
    }


    public static Coroutine InvokeRepeating(this MonoBehaviour monoBehaviour, Action action, float initialDelay, float repeatRate)
    {
        return monoBehaviour.StartCoroutine(InvokeRepeatingImpl(action, initialDelay, repeatRate));
    }

    private static IEnumerator InvokeRepeatingImpl(Action action, float initialDelay, float repeatRate)
    {
        yield return new WaitForSeconds(initialDelay);
        while (true)
        {
            action();
            yield return new WaitForSeconds(repeatRate);
        }
    }
}
