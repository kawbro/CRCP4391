using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{

    public float speed = 0.1f;

    public Collider[] attackHitboxes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Game exit
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

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

        //Attacks
        if (Input.GetKeyDown(KeyCode.P))
        {
            LaunchAttack(attackHitboxes[0]);
        }
    }

    public int LaunchAttack(Collider col) //test if private is better
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
        foreach (Collider c in cols)
        {
            if (c.transform.parent == transform)
            {
                continue;
            }
            Debug.Log("Hit " + c.name);
            return 1;
        }

        return 0;


    }
}
