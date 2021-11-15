using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStat
{
    public override void Die()
    {
        base.Die();
        //Add death animation
        Destroy(gameObject);
    }
}
