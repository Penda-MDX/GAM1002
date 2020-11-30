using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_HitPush : MonoBehaviour
{
    public float pushForce = 1.0f;
    private Rigidbody myRB;
    private bool aHit;
    private Vector3 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(aHit)
        {
            myRB.AddForce(playerDirection* pushForce, ForceMode.Impulse);
            aHit = false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("A Hit");
            playerDirection = collision.gameObject.transform.forward;
            aHit = true;
        }
    }
}
