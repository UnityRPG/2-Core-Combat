using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("RPG/Weapon"))]
public class Weapon : ScriptableObject {

    public Transform gripTransform;

    [SerializeField] GameObject weaponPrefab; 
    public AnimationClip attackAnimation;
    public AudioClip playerAttackSound;

    public GameObject GetWeaponPrefab() {
        return weaponPrefab;
    }
}
