using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStat
{
    // Gives the player their own death
    public override void Die()
    {
        base.Die();
        PlayerManager.instance.KillPlayer();
    }
}
