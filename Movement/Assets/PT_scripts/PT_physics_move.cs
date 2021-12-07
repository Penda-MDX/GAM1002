using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_physics_move : MonoBehaviour
{
    public float fl_push_force = 10f;
    public float fl_jump_force = 10f;
    private Rigidbody rb_Physics_RigidBody;

    public PT_Foot footScript;
    private Vector3 respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb_Physics_RigidBody = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (footScript.isGrounded)
        {
            Vector3 _temporary_force = Vector3.zero;

            _temporary_force.x = Input.GetAxis("Horizontal") * fl_push_force;
            _temporary_force.z = Input.GetAxis("Vertical") * fl_push_force;

            if (Input.GetButton("Jump"))
            {
                _temporary_force.y = fl_jump_force;
            }

            rb_Physics_RigidBody.AddForce(_temporary_force);


        }
    }
    // added to work with death zone script
    public void FallToDeath()
    {
        rb_Physics_RigidBody.velocity = Vector3.zero;
        rb_Physics_RigidBody.angularVelocity = Vector3.zero;
    }
}
