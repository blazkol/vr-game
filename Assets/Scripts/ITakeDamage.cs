using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamage
{
    void TakeDamage(Gun gun, Projectile projectile, Vector3 contactPoint);
}
