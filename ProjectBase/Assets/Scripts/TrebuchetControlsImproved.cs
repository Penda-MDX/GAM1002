using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetControlsImproved : MonoBehaviour
{
    public float frontMass;
    public Rigidbody frontWeightRB;
    public HingeJoint MainJoint;
    public Rigidbody armRB;
    public GameObject armObj;
    public SpringJoint reloadingWinch;
    public Rigidbody reloadMass;
    public Spawner ballSpawn;

    private float originalMass;


    private GameObject[] partsArray;
    private Vector3[] positionsArray;
    private Quaternion[] rotationsArray;

    // Start is called before the first frame update
    void Start()
    {
        partsArray = new GameObject[transform.childCount];
        positionsArray = new Vector3[transform.childCount];
        rotationsArray = new Quaternion[transform.childCount];

        int indexCount = 0;
        foreach (Transform child in transform)
        {
            //child is your child transform
            partsArray[indexCount] = child.gameObject;
            positionsArray[indexCount] = child.position;
            rotationsArray[indexCount] = child.rotation;
            indexCount++;
        }

        //frontWeight.gameObject.SetActive(false);
        originalMass = frontWeightRB.mass;
        //frontWeightRB.mass = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (frontMass != originalMass)
        {

        }
        //Fire 
        if (Input.GetKeyUp("f"))
        {
            //reloadingWinch.spring = 0;
            reloadMass.mass = 0;
        }

        if (Input.GetKeyUp("l"))
        {
            // reloadingWinch.spring += 150;
            reloadMass.mass += 100;
        }

        if (Input.GetKeyUp("g"))
        {
            ballSpawn.numberOfTimes++;
        }

        if (Input.GetKeyUp("h"))
        {
            frontWeightRB.mass += 100;
        }

        if (Input.GetKeyUp("n"))
        {
            frontWeightRB.mass = originalMass;
        }
    }
}
