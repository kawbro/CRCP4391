using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal"); //x-axis
        float Vertical = Input.GetAxis("Vertical"); //z-axis

        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

        rigid.AddForce(move * speed);
    }
}
