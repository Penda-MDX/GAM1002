using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Basic_Move : MonoBehaviour {
    public float fl_MovementSpeed = 1;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //When you press M the item moves up
        if(Input.GetButtonUp("M"))
        {
            transform.Translate(0, fl_MovementSpeed, 0);
        }

    }
}


//Input.GetAxis("Vertical")
//Input.GetAxis("Horizontal")
