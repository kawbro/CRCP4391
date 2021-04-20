//This code needs to be configured to the player but right now for the purpose of working on things it's a seperate script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSYSTest : MonoBehaviour
{
    //Change to private ints when transistioned to player specific script
    public int currentHealth; //Current health for player
    public int maxHealth = 100; //Total health for player

    public HealthBarScript healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            TakeDamage(20);
            Debug.Log(gameObject.name + " " + currentHealth);
        }

        if(currentHealth == 0)
        {
            Time.timeScale = 0;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
