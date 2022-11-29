using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Trigger_MultiObject_States : MonoBehaviour
{

    public string currentState;
    public List<GameObject> ManagedObjects;
    public string[] states;
    public bool bl_activate = false;
    
    private bool bl_canActivate = false;
    private PT_LevelManager currentLevelManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e") && bl_canActivate)
        {
            bl_activate = !bl_activate;
            objectToActivate.SetActive(bl_activate);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bl_canActivate = true;
            currentLevelManager.ShowMessage("Press E to activate");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bl_canActivate = false;
        }

    }
}
