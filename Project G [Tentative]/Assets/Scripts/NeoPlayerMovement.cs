/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeoPlayerMovement : MonoBehaviour
{
    //private PlayerAnimation player_Animation;
    //private 

    public float walk_Speed = 3f;
    public float z_Speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<RigidBody>();
        //player_Animation = GetComponentInChildren<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        print("The value is: " + Input.GetAxisRow(Axis.HORIZONTAL_AXIS));
    }

    void FixedUpdate()
    {
        DetectMovement();
    }

    void DetectMovement()
    {
        myBody velocity = new Vector3(Input.GetAxisRow("Horizontal") * (-walk_Speed), myBody.velocity.y, Input.GetAxisRow("Vertical") * (-z_Speed));

    }
}
*/