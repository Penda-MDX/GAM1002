using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSwitch : MonoBehaviour {

    private BoxCollider Target;
    public float timeLeft = 30.0f;
    public Material changeMaterial;

    private bool countingDown = false;
    private Material startMaterial;

    private Renderer _Renderer;

    // Use this for initialization
    void Start () {

        _Renderer = gameObject.GetComponent<Renderer>();
        startMaterial = _Renderer.material;
         
    }
	
	// Update is called once per frame
	void Update () {
        if (countingDown)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                Target.isTrigger = true;
                _Renderer.material = startMaterial;
                ResetTimer();
            }
        }

    }

    public void SwitchOver()
    {
        Target = GetComponent<BoxCollider>();
        Target.isTrigger = false;
        _Renderer.material = changeMaterial;
        countingDown = true;
    }

    private void ResetTimer()
    {
        timeLeft = 30.0f;
        countingDown = false;
    }

}
