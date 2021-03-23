﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //initialize the animator for the player's animations
    }

    // Update is called once per frame
    void Update()
    {
        //Punch trigger
        if (Input.GetKeyDown("p"))
        {
            animator.SetTrigger("Punch");
            Debug.Log(gameObject.name + "P-1");
        }

        if(Input.GetKeyUp("p"))
        {
            animator.SetTrigger("Reset");
            Debug.Log(gameObject.name + "P-0");
        }
    }
}
