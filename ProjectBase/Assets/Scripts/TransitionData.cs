using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TransitionDataManager", menuName = "ScriptableObjects/TransitionManager", order = 1)]
public class TransitionData : ScriptableObject
{

    public DoorData currentDoorTransition;
    
}
