using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSwitch : MonoBehaviour
{
    public bool activateState = false;
    public List<GameObject> objectsToActivate;

    private bool canActivate = false;


    public GameObject objectToChange;
    public Renderer objectRendererToChange;
    public Material activateColour;
    public float timeToReset = 1.5f;
    private float resetTime;
    private Material startColour;
    

    // Use this for initialization
    void Start()
    {
        startColour = objectRendererToChange.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetTime != 0f && resetTime < Time.time)
        {
            objectRendererToChange.material = startColour;
        }
        if (Input.GetKeyUp("e") && canActivate)
        {
            activateState = !activateState;
            foreach(GameObject objectToActivate in objectsToActivate)
            {
                objectToActivate.SetActive(activateState);
            }
            
            objectRendererToChange.material = activateColour;
            resetTime = Time.time + timeToReset;
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canActivate = true;
            //currentLevelManager.ShowMessage("Press E to activate");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canActivate = false;
        }

    }
}
