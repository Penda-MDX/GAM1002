using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Message : MonoBehaviour
{
    [SerializeField] private Text OnScreenText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("h"))
        {
            OnScreenText.text = "This is great!";
        }
        if (Input.GetKey("j"))
        {
            OnScreenText.text = "Hamsters everywhere!";
        }


    }
}
