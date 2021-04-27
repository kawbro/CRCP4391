using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start() //Starts before Frame 1
    {
        
    }

    // Update is called once per frame
    void Update() //Starts on Frame 1/Press play
    {
        float xDirection = Input.GetAxis("Horizontal"); //Moves left & right
        float zDirection = Input.GetAxis("Vertical"); //Moves fowards & backwards

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection); //

        transform.position += moveDirection * speed; //Move with WASD by updating position
    }
}
