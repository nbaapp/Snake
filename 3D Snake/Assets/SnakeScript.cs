using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeScript : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 direction = new Vector3(0, 0, 1);
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeDirection();
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * speed * Time.deltaTime;
    }

    void changeDirection()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * 90);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.Rotate(new Vector3(1, 0, 0) * 90);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(new Vector3(0, 1, 0) * 90);
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(new Vector3(0, -1, 0) * 90);
        }
    }
}
