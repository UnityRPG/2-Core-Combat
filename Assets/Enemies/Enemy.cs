using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IDamageable {

    [SerializeField] float maxHealthPoints = 100f;

    [SerializeField] [Tooltip ("Distance the enemy can see in m")]
    float extentOfMyopia = 10f;

    [SerializeField] ParticleSystem hitParticleEffect;
    [SerializeField] float destroySecondsAfterDeath = 0.1f;
    [SerializeField] Light highLight = null;

    float currentHealthPoints = 100f;
    NavMeshAgent navMeshAgent = null;
    GameObject player = null;
    
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
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        var playerPosition = player.transform.position;
        if (Vector3.Distance(playerPosition, transform.position) <= extentOfMyopia)
        {
            navMeshAgent.SetDestination(playerPosition); // rush the player
        }
        
    }

    void OnMouseOver()
    {
        Highlight(true);
    }

    void OnMouseExit()
    {
        Highlight(false);
    }

    void Highlight(bool isHighlighted)
    {
        highLight.enabled = isHighlighted;
    }

    // Only allow calling through interface, not enemy.TakeDamage()
    void IDamageable.TakeDamage(float damage)
    {
        currentHealthPoints = Mathf.Clamp(currentHealthPoints - damage, 0, maxHealthPoints);
        if (hitParticleEffect) { hitParticleEffect.Play(); };
        if (currentHealthPoints <= 0)
        {
            Destroy(gameObject, destroySecondsAfterDeath);
        }
    }
}
