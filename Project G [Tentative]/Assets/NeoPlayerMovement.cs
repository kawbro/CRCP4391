using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeoPlayerMovement : MonoBehaviour
{
    //private PlayerAnimation player_Animation
    private Rigidbody myBody;
    public float speed = 3.0f;
    //private Rigid


    // Start is called before the first frame update
    void Start()
    {
        myBody = getComponent<Rigidbody>();
        //myBody = getComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }
}
