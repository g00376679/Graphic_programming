using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    // variables
    // horizontal and vertical speed
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    // pitch and yaw
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update () {
        // method mouse
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}

