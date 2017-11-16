using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_TriggerWithActivate : MonoBehaviour {
    public bool bl_activate=false;
    public GameObject objectToActivate;

    private PT_LevelManager currentLevelManager;
    
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.Find("LevelManager");
        currentLevelManager = go.GetComponent<PT_LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            bl_activate = true;
        }
        else
        {
            bl_activate = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            currentLevelManager.ShowMessage("Press E to activate");
            objectToActivate.SetActive(bl_activate);
        }
    }
}

