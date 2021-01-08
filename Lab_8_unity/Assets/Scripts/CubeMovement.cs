using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
   

    // variables
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * Time.deltaTime, Camera.main.transform);
            rb.AddForce(0, 0, 0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime, Camera.main.transform);
            rb.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back * Time.deltaTime, Camera.main.transform);
            rb.AddForce(0, 0, -0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * Time.deltaTime, Camera.main.transform);
            rb.AddForce(0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 5f, 0, ForceMode.Impulse);
            //transform.Translate(Vector3.up * 1, Camera.main.transform);
        }
    }
}