using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloor : MonoBehaviour
{

    public Vector3 respawnSafePosition;
    public Vector3 respawnSafeRotation;
    private GameObject PC;

    private bool shouldRespawn;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shouldRespawn)
        {
            shouldRespawn = false;
            PC.transform.position = respawnSafePosition;
            PC.transform.eulerAngles = respawnSafeRotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Death");
            shouldRespawn = true;
            PC = other.gameObject;

        }
    }
}
