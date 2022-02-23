using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeapon : Weapon
{
    public BulletNames BulletName => bulletName;
    [SerializeField] private BulletNames bulletName;
    public override void Fire(PlayerController sender)
    {
         GameObject objectGame = PoolController.Pop(bulletName.ToString());
         Bullet bullet = objectGame.GetComponent<Bullet>();
         bullet.owner = sender;
         bullet.transform.position = transform.position;
         bullet.transform.rotation = transform.rotation;
         bullet.Init();
    }
}
