using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnRespawn : MonoBehaviour
{
    public GameObject spawnedThing;
    public GameObject[] thingsToBeReset;
    private Vector3[] positionsOfThings;
    public bool respawn = false;

    // Start is called before the first frame update
    void Start()
    {
        positionsOfThings = new Vector3[thingsToBeReset.Length];
        //foreach(GameObject thing in thingsToBeReset)
        for(int i=0; i<thingsToBeReset.Length;i++)
        {
            positionsOfThings[i] = thingsToBeReset[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (respawn)
        {
            for (int i = 0; i < thingsToBeReset.Length; i++)
            {
                if (thingsToBeReset[i] == null)
                {
                    thingsToBeReset[i] = Instantiate(spawnedThing, positionsOfThings[i], Quaternion.identity);
               
                }
            }
            respawn = false;
        }

    }
}
