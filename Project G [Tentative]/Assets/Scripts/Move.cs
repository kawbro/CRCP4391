//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal"); //GetAxis(Horiz) checks if using A & D
        float zDirection = Input.GetAxis("Vertical"); //GetAxis(Vert) checks if using W & S

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection); //xDir = forward/back, y = 0.0f (jump), zDir = Side to Side

        transform.position += moveDirection;
    }
}
