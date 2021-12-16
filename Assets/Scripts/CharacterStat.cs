
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public HealthBar healthBar;

    public int damage;

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {

    }

    // How the character takes damage
    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage ");

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    //Gives a space where each character can die in a specific way
    public virtual void Die ()
    {
        //Die in some way
        Debug.Log(transform.name + " died ");
    }
}
