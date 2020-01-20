using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveandRotate : MonoBehaviour
{

    public float fl_MovementSpeed = 6f;
    public float AirMovementSpeed = 3f;
    public float fl_gravity = 15f;
    public float fl_JumpForce = 8.0f;
    public float fallMultiplier = 2.0f;

    private Vector3 V3_move_direction = Vector3.zero;
    private CharacterController cc_Reference_To_Character_Controller;
    private bool canJumpAgain = true;
    // Start is called before the first frame update
    void Start()
    {
        cc_Reference_To_Character_Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (cc_Reference_To_Character_Controller.isGrounded)
        {
            canJumpAgain = true;
            V3_move_direction.y = 0;

            MovePC(fl_MovementSpeed);

        }
        else
        {
            //AirMovementSpeed
            MovePC(AirMovementSpeed);
            V3_move_direction.y -= fl_gravity * Time.deltaTime;

            //if the PC is falling (has passed apogee) then increase the gravity impact
            if (V3_move_direction.y < 0)
            {
                V3_move_direction.y -= (fl_gravity * Time.deltaTime) * fallMultiplier;
            }

        }

        if (cc_Reference_To_Character_Controller.isGrounded && Input.GetButton("Jump"))
        {
            V3_move_direction.y = fl_JumpForce;

        }
        else if (Input.GetButtonDown("Jump") && canJumpAgain)
        {
            V3_move_direction.y += fl_JumpForce;
            canJumpAgain = false;
        }

        cc_Reference_To_Character_Controller.Move(V3_move_direction);
    }


    void MovePC(float _speed)
    {
        Vector3 _temp_direction = Vector3.zero;

        _temp_direction.x = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _temp_direction.z = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        V3_move_direction = gameObject.transform.TransformDirection(_temp_direction);
    }

}
