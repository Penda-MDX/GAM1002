using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTurnOn : MonoBehaviour {
    private MouseSwitch mouseSwitchScript;
    private Ray ray;
    private RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                mouseSwitchScript = hit.collider.gameObject.GetComponent<MouseSwitch>();
                if (mouseSwitchScript != null)
                {
                    mouseSwitchScript.SwitchOver();
                }
            }
        }
    }
}
