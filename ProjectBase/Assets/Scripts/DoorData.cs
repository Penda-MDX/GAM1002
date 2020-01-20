using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoorData", menuName = "ScriptableObjects/DoorData", order = 1)]
public class DoorData : ScriptableObject
{

    public string doorName;

    public string targetSceneName;

    public Vector3 arrivalPosition;

    public Vector3 arrivalRotation;

}
