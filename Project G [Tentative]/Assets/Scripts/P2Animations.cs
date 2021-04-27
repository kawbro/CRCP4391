using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Animations : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("Punch");
            Debug.Log(gameObject.name + "U-1");
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            animator.SetTrigger("Reset");
            Debug.Log(gameObject.name + "U-0");
        }
    }


}
