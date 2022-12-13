using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_FallingPlatform : MonoBehaviour
{
    public float secondsToSwitch;
    
    private float timeToSwitchOff;
    private bool playerLanded;
    private float timeToNextPlatform;

    // Start is called before the first frame update
    void Awake()
    {
        playerLanded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLanded && timeToSwitchOff < Time.time)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            playerLanded = false;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerLanded = true;
            timeToSwitchOff = Time.time + secondsToSwitch;
            
        }
    }
}
