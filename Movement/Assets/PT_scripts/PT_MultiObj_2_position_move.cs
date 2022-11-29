using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_MultiObj_2_position_move : MonoBehaviour
{
    public Transform[] WayPoints;
    public int currentWP;

    private Transform targetPosition;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StateChange(string StateName)
    {
        switch (StateName)
        {
            case "Up":
                targetPosition = WayPoints[0];
                break;
            case "Down":
                targetPosition = WayPoints[1];
                break;
            
        }
    }
}
