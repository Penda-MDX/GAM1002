using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalManager : MonoBehaviour
{

    public TransitionData currentTransitionManager;
    public GameObject PC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        PC.transform.position = currentTransitionManager.currentDoorTransition.arrivalPosition;
        PC.transform.eulerAngles = currentTransitionManager.currentDoorTransition.arrivalRotation;
    }
    // Update is called once per frame
    void Update()
    {
 

    }
}
