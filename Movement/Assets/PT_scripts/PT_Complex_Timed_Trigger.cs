using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Manage a series of platforms that appear and disappear in order 
 * this version the next platform appears a fixed time after the player lands on it
 *
 */

public class PT_Complex_Timed_Trigger : MonoBehaviour
{
    public float secondsToSwitch;
    public float secondsToNextPlatform;
    public GameObject nextPlatform;

    private float timeToSwitchOff;
    private bool playerLanded;
    private float timeToNextPlatform;

    // Start is called before the first frame update
    void Awake()
    {
        timeToSwitchOff = Time.time + secondsToSwitch;
        timeToNextPlatform = Time.time + secondsToNextPlatform;
        playerLanded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLanded && timeToSwitchOff < Time.time)
        {
            gameObject.SetActive(false);
            playerLanded = false;
        }

        if(playerLanded && timeToNextPlatform < Time.time)
        {
            nextPlatform.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerLanded = true;
            timeToSwitchOff = Time.time + secondsToSwitch;
            timeToNextPlatform = Time.time + secondsToNextPlatform;
        }
    }
}
