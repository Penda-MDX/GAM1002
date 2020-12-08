using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Spawn_with_Force : MonoBehaviour
{
    public int int_numberOfTimes = 3;
    public bool bl_infinite = false;
    public float fl_timeBetween = 2f;
    public GameObject go_spawnee;
    public Vector3 forceVector;

    private float fl_nextTime;
    private int int_countSoFar = 0;
    private GameObject newObject;

	// Use this for initialization
	void Start () {
        fl_nextTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        //check there is a spawnee set
        if (go_spawnee != null)
        {
            //has the time between spawns passed
            if (fl_nextTime<Time.time)
            {
                //spawn if either infinite is set or the number of spawns have been not been reached
                if (bl_infinite || int_countSoFar < int_numberOfTimes)
                {
                    newObject = Instantiate(go_spawnee, transform.position, transform.rotation);
                    //grab the newobjects rigidbody and give it a shove
                    newObject.GetComponent<Rigidbody>().AddForce(forceVector,ForceMode.Impulse);
                    //update count
                    int_countSoFar++;
                    //set the next time to spawn
                    fl_nextTime = Time.time + fl_timeBetween;
                    //keep it tidy and forget about it
                    newObject = null;
                }
            }
        }
	}
}
