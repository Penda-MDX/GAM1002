using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_RandomDropListSpawner : MonoBehaviour
{

    //Spawns objects every loopTime secondas at a fixed height (spawnHeight) at random positions in a x,y rectangle (spawnArea)
    //Uses a list of objects that it selects from randomly
    
    public float loopTime;
    public List<GameObject> spawneeList;
    public float spawnHeight;
    public Rect spawnArea;

    private float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + loopTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            if (spawneeList.Count > 0)
            {
                int rndIndex = Mathf.FloorToInt(Random.Range(0, spawneeList.Count));
                float rndX = Random.Range(spawnArea.xMin,spawnArea.xMax);
                float rndZ = Random.Range(spawnArea.yMin, spawnArea.yMax);
                Vector3 newPosition = new Vector3(rndX, spawnHeight, rndZ);


                Instantiate(spawneeList[rndIndex], newPosition, Quaternion.identity);
                nextSpawnTime = Time.time + loopTime;
            }
        }
    }
}
