using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{

    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal"); //Moves left & right
        float zDirection = Input.GetAxis("Vertical"); //Moves fowards & backwards

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
    }
}
