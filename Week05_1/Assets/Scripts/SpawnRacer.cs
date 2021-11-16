using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRacer : MonoBehaviour
{
    public GameObject racerToBeSpawned;
    public float maxForce = 5.2f;
    public float minForce = 0.2f;
    public float secondsToStart = 2f;
    public string keyToStart = "h";
    public string trapName;

    private float startTime = 0f;
    private GameObject racer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToStart))
        {
            startTime = Time.time + secondsToStart;
        }

        if(startTime!=0 && Time.time > startTime)
        {
            racer = Instantiate(racerToBeSpawned, transform.position, Quaternion.identity);
            racer.GetComponent<BasicPhysicsMove>().pushForce = Random.Range(minForce,maxForce);
            racer.name = trapName;
            Destroy(racer, 8f);
            startTime = 0f;
        }
        

    }
}
