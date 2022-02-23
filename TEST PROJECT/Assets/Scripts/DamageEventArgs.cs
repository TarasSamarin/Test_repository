using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEventArgs : EventArgs
{
    public float Damage { get; set; }
    public DamageEventArgs(float damage)
    {
        Damage = damage;
    }
}
