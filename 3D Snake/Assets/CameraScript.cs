using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
    }
}
