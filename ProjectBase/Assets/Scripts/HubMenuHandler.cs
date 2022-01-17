using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class HubMenuHandler : MonoBehaviour
{
    public Text SceneTextField;

    // Start is called before the first frame update
    void Start()
    {
        SceneTextField.text = "Scene: " + SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneSelect(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }
}
