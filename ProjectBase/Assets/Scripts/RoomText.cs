using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoomText : MonoBehaviour
{
    public Canvas mainCanvas;
    public Text textObject;
    

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        textObject.text = scene.name;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
