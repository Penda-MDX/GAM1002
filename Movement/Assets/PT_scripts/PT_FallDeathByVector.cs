using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_FallDeathByVector : MonoBehaviour
{
    public float yFloor;
    public float yCeiling;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y< yFloor || transform.position.y > yCeiling)
        {
            gameObject.SendMessage("FallToDeath", null, SendMessageOptions.DontRequireReceiver);
        }
    }
}
