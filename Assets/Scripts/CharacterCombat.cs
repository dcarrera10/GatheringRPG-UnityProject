using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStat))]
public class CharacterCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCooldown = 0f;

    CharacterStat myStats;

    void Start()
    {
        myStats = GetComponent<CharacterStat>();
    }

    // Setting up the cooldown to go down over time
    void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    // Damage is taken depending on the target's stats
    public void Attack(CharacterStat targetStats)
    {
        if (attackCooldown <= 0f)
        {
            targetStats.TakeDamage(myStats.damage);
            attackCooldown = 1f / attackSpeed;
        }
        
    }

}
