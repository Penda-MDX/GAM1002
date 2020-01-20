using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;
    private bool byDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (byDoor && Input.GetKeyUp("e"))
        {
            currentTransitionManager.currentDoorTransition = transitionInformation;
            SceneManager.LoadScene(transitionInformation.targetSceneName);
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
