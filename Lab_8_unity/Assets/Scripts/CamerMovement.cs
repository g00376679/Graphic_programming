using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    // player object..
    public GameObject player;
   
    // vector
    private Vector3 offset;

    void Start ()
    {
        //setting offset here
        offset = transform.position - player.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
    }
}
