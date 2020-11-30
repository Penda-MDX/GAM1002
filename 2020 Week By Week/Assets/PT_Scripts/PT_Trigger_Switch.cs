﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Trigger_Switch : MonoBehaviour {

    public GameObject objectToBeActivated;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Debug.Log("Something is in the trigger!");
            objectToBeActivated.SetActive(true);
        }
    }
}
