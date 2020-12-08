using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Basic_Physics_Move : MonoBehaviour
{
    public float pushForce = 10.0f;
    private Rigidbody PhysicsRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        PhysicsRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _temporaryForceVector = Vector3.zero;

        _temporaryForceVector.x = Input.GetAxis("Horizontal") * pushForce;
        _temporaryForceVector.z = Input.GetAxis("Vertical") * pushForce;

        PhysicsRigidbody.AddForce(_temporaryForceVector);
    }
}
