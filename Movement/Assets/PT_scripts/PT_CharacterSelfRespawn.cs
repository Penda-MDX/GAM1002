using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_CharacterSelfRespawn : MonoBehaviour
{
    private bool respawn;
    private GameObject levelManager;
    // Use this for initialization
    void Start()
    {
        levelManager = GameObject.Find("LevelManager");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (respawn)
        {
            gameObject.transform.position = levelManager.GetComponent<PT_LevelManager>().lastGoodCheckpoint.transform.position;
            respawn = false;
            levelManager.GetComponent<ResetOnRespawn>().respawn = true;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("I hit a " + hit.gameObject.name);
        if(hit.gameObject.tag == "Danger")
        {
            respawn = true;
        }
    }
    void OnCollisionEnter(Collision hit)
    {
        Debug.Log("I hit a " + hit.gameObject.name);
        if (hit.gameObject.tag == "Danger")
        {
            respawn = true;
        }
    }


}
