using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is call before the first frame update

    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //setting variables
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // move cube
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        // force
        rb.AddForce(movement * speed);
    }
}
