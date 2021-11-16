using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Climbing : MonoBehaviour
{
    public bool isClimbing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Climbable")
        {
            isClimbing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Climbable")
        {
            isClimbing = false;
        }
    }

}
