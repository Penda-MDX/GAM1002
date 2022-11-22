using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Death_Zone : MonoBehaviour {



    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Death");
        other.gameObject.SendMessage("FallToDeath",null, SendMessageOptions.DontRequireReceiver);
    }
}
