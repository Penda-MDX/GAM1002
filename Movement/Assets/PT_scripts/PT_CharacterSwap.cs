using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_CharacterSwap : MonoBehaviour
{
    public PT_Improved_CC_w_boost playerCharacter1;
    public PT_Improved_CC_w_boost playerCharacter2;
    public PT_Side_Scrolling_Follow_Camera cameraFollowScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            if (playerCharacter1.isActiveAndEnabled)
            {
                playerCharacter1.enabled = false;
                playerCharacter2.enabled = true;
                cameraFollowScript.go_thingToBeFollowed = playerCharacter2.gameObject;
            }
            else
            {
                playerCharacter1.enabled = true;
                playerCharacter2.enabled = false;
                cameraFollowScript.go_thingToBeFollowed = playerCharacter1.gameObject;
            }

        }
    }
}
