using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_FallDeathBase : MonoBehaviour
{
    public Transform checkPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Checkpoint")
        {
            checkPoint = other.gameObject.transform;
        }
    }


    public void FallToDeath()
    {
        Debug.Log("Respawn");
        gameObject.transform.position = checkPoint.position;
    }
}
