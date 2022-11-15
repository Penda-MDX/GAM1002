using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_basic_death_zone : MonoBehaviour {
    
    private bool respawn;
    private GameObject collidingPlayerCharacter;
    private GameObject levelManager;
	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (levelManager == null)
        {
            levelManager = GameObject.Find("LevelManager");
        }

		if(respawn)
        {
            //grab the last good checkpoint
            Transform respawnPoint = levelManager.GetComponent<PT_LevelManager>().lastGoodCheckpoint;

            collidingPlayerCharacter.transform.position = respawnPoint.transform.position;
            //its done now turn it off
            respawn = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //this doesn't work with CC as it would need to happen in 
            //other.gameObject.transform.position = respawnPoint.transform.position;
            Debug.Log("Hit");
            //turn on respawn
            respawn = true;
            collidingPlayerCharacter = other.gameObject;


            other.gameObject.SendMessage("Respawn");
            
        }
    }
}
