using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public float dayStartTime;
    public float lengthOfDayinSeconds;
    public float secondInAnHour;
    public float elapsedTime;
    public float displayHour = 0 ;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            //start the day
            dayStartTime = Time.time;
            Debug.Log("Pressed");

        }
        elapsedTime = (Time.time - dayStartTime);
        float halfHours = Mathf.Floor(elapsedTime / secondInAnHour);
        
        if ( elapsedTime != displayHour)
        {
            
            if (halfHours % 2 == 0)
            {
                displayHour = halfHours / 2;
                timerText.text = displayHour.ToString() + ":00";
            }
            else
            {
                timerText.text = displayHour.ToString() + ":30";
            }
        }
    }
}
