using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;
    public GameObject objectToChange;
    public Renderer objectRendererToChange;
    public Material failColour;
    public float timeToReset = 1.5f;
    private float resetTime;
    private Material startColour;
    private bool byDoor;


    // Start is called before the first frame update
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

        if (byDoor && Input.GetKeyUp("e"))
        {
            if (transitionInformation != null)
            {
                currentTransitionManager.currentDoorTransition = transitionInformation;
                SceneManager.LoadScene(transitionInformation.targetSceneName);
            }
            else
            {
                Debug.Log("Locked or Something Wrong");
                
                objectRendererToChange.material = failColour;
                resetTime = Time.time + timeToReset;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Near Door");
            byDoor = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Leaving Door");
            byDoor = false;
        }
    }

}
