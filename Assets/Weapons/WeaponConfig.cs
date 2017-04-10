using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("RPG/Weapon"))]
public class WeaponConfig : ScriptableObject {

    [SerializeField] Transform gripTransform;
    [SerializeField] GameObject weaponPrefab;
    [SerializeField] AnimationClip attackAnimation;

    public GameObject CreateWeaponAsChild(Transform parent)
    {
        var weapon = Instantiate(weaponPrefab, parent);
        weapon.transform.localPosition = gripTransform.localPosition;
        weapon.transform.localRotation = gripTransform.localRotation;
        weapon.AddComponent<WeaponBehaviour>();
        return weapon;
    }
}
