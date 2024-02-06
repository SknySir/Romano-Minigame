using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public float speed = 20.0f;
    public float xRange = 37;
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        // AI loops at boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
