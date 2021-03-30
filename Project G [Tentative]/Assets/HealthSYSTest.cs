//This code needs to be configured to the player but right now for the purpose of working on things it's a seperate script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSYSTest : MonoBehaviour
{
    //Change to private ints when transistioned to player specific script
    public int currentHealth; //Current health for player
    public int totalHealth; //Total health for player

    // Start is called before the first frame update
    void Start()
    {
        totalHealth = 100;
        currentHealth = totalHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            currentHealth -= 20;
            Debug.Log(gameObject.name + " " + currentHealth);
        }
    }
}
