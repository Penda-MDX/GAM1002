using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_CollectGetBiggerScript : MonoBehaviour
{
    public float growthFactor;
    public bool grow;

    // Update is called once per frame
    void Update()
    {
        if (grow)
        {
            gameObject.transform.localScale = gameObject.transform.localScale * growthFactor;
            Vector3 newPosition = gameObject.transform.position;
            newPosition.y += 0.5f;
            gameObject.transform.position = newPosition;
            grow = false;
        }
    }
// message function to handle collecting something
    public void Collected()
    {
        grow = true;
    }
}
