using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Basic_CC_Move : MonoBehaviour {
    public float fl_MovementSpeed = 6f;
    public float fl_gravity = 2f;
    public float fl_JumpForce = 0.8f;
    private Vector3 V3_move_direction = Vector3.zero;

    private bool jumpPressed;
    private CharacterController cc_Reference_To_Character_Controller;
    // Use this for initialization
    void Start()
    {
        cc_Reference_To_Character_Controller = GetComponent<CharacterController>();

    }
    // Update is called once per frame
    void Update()
    {


        if (cc_Reference_To_Character_Controller.isGrounded)
        {
            V3_move_direction.x = Input.GetAxis("Horizontal");
            V3_move_direction.y = 0;
            V3_move_direction.z = Input.GetAxis("Vertical");
            V3_move_direction = V3_move_direction * fl_MovementSpeed * Time.deltaTime;

            if (Input.GetButtonUp("Jump"))
            {
                V3_move_direction.y = fl_JumpForce;
            }
        }
        else
        {
            V3_move_direction.y -= fl_gravity * Time.deltaTime;
        }
       
    }
    void FixedUpdate()
    {
         cc_Reference_To_Character_Controller.Move(V3_move_direction);
    }
}
