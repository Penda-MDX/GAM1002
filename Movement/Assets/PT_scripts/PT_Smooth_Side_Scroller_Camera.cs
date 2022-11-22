using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Smooth_Side_Scroller_Camera : MonoBehaviour
{
    public GameObject go_thingToBeFollowed;
    public float fl_distanceOn_zAxis = 10f;
    public float fl_distanceOn_xAxis = -3f;
    public float fl_distanceOn_yAxis = -3f;
    public bool bl_pointAt = true;
    public float speed;
    private Vector3 v3_new_camera_position = Vector3.zero;
    private Vector3 v3_new_camera_target_position;
    private Vector3 start_position;
    private bool interpolating = false;
    private float startTime;
    private float journeyLength;

    // Use this for initialization
    void Start()
    {
        //if a thing to be followed by the camera has not been defined in the editor then 
        if (go_thingToBeFollowed == null)
        {
            //Try getting all the objects with the Player Tag and pick the first one
            GameObject[] _List_Of_GameObjects = GameObject.FindGameObjectsWithTag("Player");
            go_thingToBeFollowed = _List_Of_GameObjects[0];
        }
        //if there is still no object what do we do?
    }

    // Update is called once per frame
    void Update()
    {
        // print(go_thingToBeFollowed.transform.position.x);
        v3_new_camera_position.x = go_thingToBeFollowed.transform.position.x - fl_distanceOn_xAxis;
        v3_new_camera_position.y = go_thingToBeFollowed.transform.position.y - fl_distanceOn_yAxis;
        v3_new_camera_position.z = go_thingToBeFollowed.transform.position.z - fl_distanceOn_zAxis;
        //
        if (v3_new_camera_position.z != transform.position.z || v3_new_camera_position.x != transform.position.x || v3_new_camera_position.y != transform.position.y)
        {
            if (!interpolating)
            {
                interpolating = true;
                v3_new_camera_target_position = v3_new_camera_position;
                start_position = transform.position;
                // Keep a note of the time the movement started.
                startTime = Time.time;

                // Calculate the journey length.
                journeyLength = Vector3.Distance(start_position, v3_new_camera_position);
            }
        }

        if (interpolating)
        {
            // Distance moved equals elapsed time times speed..
            float distCovered = (Time.time - startTime) * speed;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(start_position, v3_new_camera_target_position, fractionOfJourney);

            if (fractionOfJourney >= 1)
            {
                interpolating = false;
            }
        }
        // should we rotate the camera to point at the thing we are following?
        if (bl_pointAt)
        {
            transform.LookAt(go_thingToBeFollowed.transform);
        }
    }
}
