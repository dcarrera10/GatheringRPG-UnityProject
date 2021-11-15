
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public int damage;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {

    }
    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage ");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die ()
    {
        //Die in some way
        Debug.Log(transform.name + " died ");
    }
}
