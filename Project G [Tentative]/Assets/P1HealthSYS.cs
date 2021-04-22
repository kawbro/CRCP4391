//This code needs to be configured to the player but right now for the purpose of working on things it's a seperate script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HealthSYS: MonoBehaviour
{
    //Change to private ints when transistioned to player specific script
    public int currentHealth; //Current health for player
    public int maxHealth = 100; //Total health for player

    public HealthBarScript healthBar;

    public bool isHit;
    public int Damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //if(P1Movement.LaunchAttack(Collider col) == 1)
            //{
            TakeDamage(Damage);
            //healthBar = Health Bar P1;
            healthBar.SetHealth(currentHealth);
            //}
            Debug.Log(gameObject.name + " " + currentHealth);
        }

        if (currentHealth == 0)
        {
            Time.timeScale = 0; //Stops game when health reaches 0
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player 1" || col.tag == "Player 2")
        {
            col.SendMessage((isHit) ? "TakeDamage" : null, Damage);
            TakeDamage(Damage);
        }

    }

    void TakeDamage(int damage)
    {
        damage = Damage;
        currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);
    }
}
