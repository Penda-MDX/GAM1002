using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("k"))
        {
            transform.Translate(0, movementSpeed, 0);
        }

        if (Input.GetKeyUp("m"))
        {
            transform.Translate(0, -movementSpeed, 0);
        }
    }
}
