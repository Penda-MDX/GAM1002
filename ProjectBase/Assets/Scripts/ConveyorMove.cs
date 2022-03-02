using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMove : MonoBehaviour
{
    public float forceOfMovement;
    public bool activated;
    private List<Rigidbody> rigidbodiesOnBelt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody _tempRB = other.gameObject.GetComponent<Rigidbody>();
        if (_tempRB != null)
        {
            if (activated)
            {
                Vector3 _direcion = transform.TransformDirection(Vector3.forward * forceOfMovement);
                _tempRB.AddForce(_direcion,ForceMode.Force);
            }
        }
    }
}
