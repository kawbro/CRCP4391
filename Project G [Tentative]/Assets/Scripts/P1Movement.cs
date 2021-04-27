using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Movement : MonoBehaviour
{

    public float speed = 0.1f;

    public Collider[] attackHitboxes;

    //public P1HealthSYS health; //Test to see if hit detection works better
    //int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Game exit
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        //Movement
        float xDirection = Input.GetAxis("Horizontal"); //Moves left & right
        float zDirection = Input.GetAxis("Vertical"); //Moves fowards & backwards

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;
        }

        //Attacks
        if(Input.GetKeyDown(KeyCode.U))
        {
            LaunchAttack(attackHitboxes[0]);
        }
    }

    public void LaunchAttack(Collider col) //test if private is better
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
        foreach (Collider c in cols)
        {
            if (c.transform.parent == transform)
            {
                continue;
            }
            Debug.Log("Hit " + c.name);
            //return 1;
            //health.TakeDamage(damage);
        }

       // return 0;


    }
}
