using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberOfTimes = 3;
    public bool infiniteSpawning = false;
    public float timeBetweenSpawns = 1f;
    public GameObject spawnee;

    private float fl_nextTime;
    private int int_countSoFar = 0;

    // Use this for initialization
    void Start()
    {
        fl_nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //check there is a spawnee set
        if (spawnee != null)
        {
            //has the time between spawns passed
            if (fl_nextTime < Time.time)
            {
                //spawn if either infinite is set or the number of spawns have been not been reached
                if (infiniteSpawning || int_countSoFar < numberOfTimes)
                {
                    Instantiate(spawnee, transform.position, transform.rotation);
                    //update count
                    int_countSoFar++;
                    //set the next time to spawn
                    fl_nextTime = Time.time + timeBetweenSpawns;
                }
            }
        }
    }

    public void ResetToNumber(int newNumber)
    {
        int_countSoFar = 0;
        numberOfTimes = newNumber;
    }
}
