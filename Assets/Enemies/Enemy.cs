using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable {

    [SerializeField] float maxHealthPoints = 100f;
    [SerializeField] ParticleSystem hitParticleEffect;

    float currentHealthPoints = 100f;
    
    public float healthAsPercentage
    {
        get
        {
            return currentHealthPoints / maxHealthPoints;
        }
    }

    void Start()
    {
        if (!hitParticleEffect) { Debug.LogWarning("Enemy " + gameObject + " has no hit particle effect"); }
    }

    // Only allow calling through interface, not enemy.TakeDamage()
    void IDamageable.TakeDamage(float damage)
    {
        currentHealthPoints = Mathf.Clamp(currentHealthPoints - damage, 0, maxHealthPoints);
        if (hitParticleEffect) { hitParticleEffect.Play(); };
    }
}
