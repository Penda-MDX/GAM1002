using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerResetSwitch : MonoBehaviour
{
    public GameObject spawnerToReset;
    public int numberToReset;

    public GameObject objectToChange;
    public Renderer objectRendererToChange;
    public Material activateColour;
    public float timeToReset = 1.5f;
    private float resetTime;
    private Material startColour;
    private bool bySwitch;

    // Start is called before the first frame update
    void Start()
    {
        startColour = objectRendererToChange.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetTime != 0f && resetTime < Time.time)
        {
            objectRendererToChange.material = startColour;
        }

        if (bySwitch && Input.GetKeyUp("e"))
        {
            spawnerToReset.GetComponent<Spawner>().ResetToNumber(numberToReset);
            objectRendererToChange.material = activateColour;
            resetTime = Time.time + timeToReset;
        }
            
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bySwitch = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bySwitch = false;
        }
    }
}
