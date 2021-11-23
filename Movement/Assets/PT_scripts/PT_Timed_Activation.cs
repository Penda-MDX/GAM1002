using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Timed_Activation : MonoBehaviour
{
    public float secondsBetweenSwitches;
    public List<GameObject> switchedObjects;

    private float timeToSwitch;

    // Start is called before the first frame update
    void Start()
    {
        timeToSwitch = Time.time + secondsBetweenSwitches;    
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToSwitch < Time.time) 
        {
            foreach (GameObject switcher in switchedObjects)
            {
                switcher.SetActive(!switcher.activeSelf);
            }

            timeToSwitch = Time.time + secondsBetweenSwitches;
        }
    }
}
