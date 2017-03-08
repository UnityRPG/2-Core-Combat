using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] float damagePerShot = 10f;
    [SerializeField] float selfDestructAfterSeconds = 3f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, selfDestructAfterSeconds);
	}
	
	void OnTriggerEnter(Collider collider)
	{
        var damageableVictim = collider.gameObject.GetComponent(typeof(IDamageable));
        if (damageableVictim)
        {
            (damageableVictim as IDamageable).TakeDamage(damagePerShot);
        }
		Destroy (gameObject); // TODO consider passing through, e.g. water
	}
}
