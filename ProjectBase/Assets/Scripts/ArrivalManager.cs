using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalManager : MonoBehaviour
{

    public TransitionData currentTransitionManager;
    public GameObject PC;
    public DoorData freshStartEntryPoint;
    public bool arrival;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        if (currentTransitionManager.currentDoorTransition == null)
        {
            currentTransitionManager.currentDoorTransition = freshStartEntryPoint;
        }
        if (currentTransitionManager.transiting)
        {
            Debug.Log("Arrival Through Door");
        }
        else
        {
            Debug.Log("Arrival From Void");
        }

        arrival = true;

    }
    void FixedUpdate()
    {
        if (arrival)
        {
            arrival = false;
            PC.transform.position = currentTransitionManager.currentDoorTransition.arrivalPosition;
            PC.transform.eulerAngles = currentTransitionManager.currentDoorTransition.arrivalRotation;
            //PC.transform.Find("Main Camera").transform.eulerAngles= new Vector3(0,0,0);
            Debug.Log("Arrival rotation: " + currentTransitionManager.currentDoorTransition.arrivalRotation);
            currentTransitionManager.transiting = false;
        }
    }

    private void OnDestroy()
    {
        if (!currentTransitionManager.transiting)
        {
            currentTransitionManager.currentDoorTransition = null;
        }
    }
    // Update is called once per frame
    void Update()
    {


    }
}