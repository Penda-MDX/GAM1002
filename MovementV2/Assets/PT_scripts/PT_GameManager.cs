using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PT_GameManager : MonoBehaviour
{
    public Transform levelStartPoint;

    private GameObject PlayerCharacter;
    private bool ResetPC;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCharacter = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("l"))
        {
            ResetPC = true;
        }
    }

    void FixedUpdate()
    {
        if(ResetPC)
        {
            ResetPC = false;
            RestartLevel();
        }

    }
    public void NextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            //Load the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }

    }

    public void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene());
        if(PlayerCharacter!=null)
        {
            PlayerCharacter.transform.position = levelStartPoint.position;
        }else{
            Debug.Log("Restart Failed");
        }
        
        
    }

}
