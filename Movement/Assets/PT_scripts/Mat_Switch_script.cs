using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat_Switch_script : MonoBehaviour
{
    public Material[] switchableMaterials;
    public ParticleSystem theSystem;

    private int materialIndex;
    // Start is called before the first frame update
    void Start()
    {
        materialIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")){
            materialIndex++;
            if (materialIndex < switchableMaterials.Length)
            {
                theSystem.GetComponent<Renderer>().material = switchableMaterials[materialIndex];
            }
            else
            {
                materialIndex = 0;
                theSystem.GetComponent<Renderer>().material = switchableMaterials[materialIndex];
            }
        }
    }
}
