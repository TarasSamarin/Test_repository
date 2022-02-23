using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponIconsData
{
    public BulletNames BulletName;
    public Sprite Sprite;
}

[CreateAssetMenu(fileName = "Data", menuName ="ScriptableObject")]
public class WeaponIconsScriptableObject : ScriptableObject
{
    public List<WeaponIconsData> WeaponIcons;
}
