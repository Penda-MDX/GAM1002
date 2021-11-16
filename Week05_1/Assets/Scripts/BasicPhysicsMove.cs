using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPhysicsMove : MonoBehaviour
{
    public float pushForce = 10f;
    private Rigidbody boxRB;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        boxRB = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _temporaryForceVector = Vector3.zero;
        _temporaryForceVector.x = Input.GetAxis("Horizontal") * pushForce;
        _temporaryForceVector.y = Input.GetAxis("Vertical") * pushForce;

        boxRB.AddForce(_temporaryForceVector);

        if (Input.GetKeyDown("r"))
        {
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        //remove the forces
        boxRB.velocity = Vector3.zero;
    }
}
