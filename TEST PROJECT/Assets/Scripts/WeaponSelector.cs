using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponSelector : MonoBehaviour
{
    public class WeaponChangeEvent: UnityEvent<Weapon> { }
    public WeaponChangeEvent OnWeaponChanged = new WeaponChangeEvent();
    public Weapon CurrentWeapon { get; private set; }

    private Weapon[] weapons;
    private int currentWeaponIndex;
    public void ChangeNextWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Length;
        CurrentWeapon = weapons[currentWeaponIndex];
        OnWeaponChanged.Invoke(CurrentWeapon);
    }

    public void ChangePreviousWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex - 1 + weapons.Length) % weapons.Length;
        CurrentWeapon = weapons[currentWeaponIndex];
        OnWeaponChanged.Invoke(CurrentWeapon);
    }

    public void Init()
    {
        weapons = GetComponentsInChildren<Weapon>();
        currentWeaponIndex = 0;
        CurrentWeapon = weapons[currentWeaponIndex];
    }
}
