using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_PhysicsFallingCharacter : MonoBehaviour
{
    public float fl_MovementSpeed = 6f;
    public float fl_JumpForce = 8.0f;
    public PT_Foot footScript;
    public float maxVelocity = 5f;
    public float parachuteTime = 1f;
    public float groundDrag = 2;
    public float movingDrag = 0;
    public float airDrag = 0.5f;
    private Vector3 V3_move_direction = Vector3.zero;
    private Rigidbody characterRB;
    private float timeOut;
    private bool parachuteReady = true;

    public GameObject indicatorObject;
    public Material ReadyMaterial;
    public Material DrainedMaterial;

    // Use this for initialization
    void Start()
    {
        characterRB = GetComponent<Rigidbody>();
        timeOut = parachuteTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (parachuteReady)
        {
            indicatorObject.GetComponent<Renderer>().material = ReadyMaterial;
        }
        else
        {
            indicatorObject.GetComponent<Renderer>().material = DrainedMaterial;
        }


        if (characterRB.velocity.magnitude < maxVelocity)
        {
            V3_move_direction.x = Input.GetAxis("Horizontal");
            V3_move_direction.y = 0;
            V3_move_direction.z = Input.GetAxis("Vertical");
            V3_move_direction = V3_move_direction * fl_MovementSpeed * Time.deltaTime;
            if (V3_move_direction != Vector3.zero)
            {
                characterRB.AddRelativeForce(V3_move_direction);
                characterRB.drag = movingDrag;
            }
            else
            {
                characterRB.drag = groundDrag;
            }

        }
        else
        {
            characterRB.drag = groundDrag;
        }

        //Debug.Log(timeOut);
        if (Input.GetButton("Jump") && parachuteReady)
        {
            characterRB.AddRelativeForce(transform.up * fl_JumpForce);
            characterRB.drag = airDrag;
            timeOut -= Time.deltaTime;
            if (timeOut < 0)
            {
                parachuteReady = false;
            }
        }
        else
        {
            if (timeOut < parachuteTime)
            {
                timeOut += Time.deltaTime;
            }
            else
            {
                timeOut = parachuteTime;
                parachuteReady = true;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpeedUp")
        {
            Destroy(other.gameObject);
        }
    }
}
