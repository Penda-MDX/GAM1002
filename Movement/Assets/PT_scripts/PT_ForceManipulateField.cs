using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_ForceManipulateField : MonoBehaviour
{
    public float hoverTime;
    public Vector3 blastOffMax;
    public Vector3 blastOffMin;
    public Vector3 hoverPosition;
    public List<float> floatList = new List<float>();
    public List<blastish> blastObjects =new List<blastish>();


    public class blastish{
        public float blastTime;
        public Vector3 blastOff;
        public Rigidbody objRB;
        public bool doneNow;
    }
    private blastish blstObj;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(blastish objBlaster in blastObjects)
        {
            if (objBlaster.blastTime < Time.time)
            {
                if (objBlaster.doneNow)
                {
                    objBlaster.objRB.velocity = Vector3.zero;
                    objBlaster.objRB.angularVelocity = Vector3.zero;
                    objBlaster.objRB.useGravity = true;
                    blastObjects.Remove(objBlaster);
                }
                else
                {
                    Debug.Log("Blast");
                    objBlaster.objRB.AddForce(objBlaster.blastOff);
                    objBlaster.doneNow = true;
                    
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody myRB = other.gameObject.GetComponent<Rigidbody>();
        if (myRB != null)
        {
            myRB.velocity = Vector3.zero;
            myRB.angularVelocity = Vector3.zero;

            myRB.velocity = new Vector3(0,1,0);
            myRB.angularVelocity = new Vector3(1, 0, 1);
            myRB.useGravity = false;
            Vector3 _tmpV3 = new Vector3(0, 0, 0);
            _tmpV3.x = Random.Range(blastOffMin.x, blastOffMax.x);
            _tmpV3.y = Random.Range(blastOffMin.y, blastOffMax.y);
            _tmpV3.z = Random.Range(blastOffMin.z, blastOffMax.z);

            blstObj = new blastish
            {
                objRB = myRB,
                blastOff = _tmpV3,
                blastTime = Time.time + hoverTime,
                doneNow = false
            };

            blastObjects.Add(blstObj);

        }
    }


}
