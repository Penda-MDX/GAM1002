using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_lifespan : MonoBehaviour
{

    public float fl_lifeSpan = 1f;
    

    private float fl_timeIsUp;
    // Start is called before the first frame update
    void Start()
    {
        fl_timeIsUp = Time.time + fl_lifeSpan;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>fl_timeIsUp)
        {
            Destroy(gameObject);
        }
    }
}
