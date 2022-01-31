using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatTrebControl : MonoBehaviour
{
    public Animator animController;
    public GameObject ballSpawnPoint;
    public GameObject ballPrefab;
    public Vector3 forceDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(animController.GetCurrentAnimatorStateInfo(0).ToString());
        Debug.Log(animController.GetLayerName(0));
        //Debug.Log(animController.);
        if (Input.GetKeyDown("f"))
        {
            animController.SetBool("isFiring", true);

        }

        if (Input.GetKeyDown("r"))
        {
            animController.SetBool("isFiring", false);
        }

        if (Input.GetKey(KeyCode.Minus))
        {
            gameObject.transform.Translate(0, 0, -1*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Equals))
        {
            gameObject.transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }

    public void TakeShot()
    {
        GameObject tmpGO = Instantiate(ballPrefab, ballSpawnPoint.transform.position, ballSpawnPoint.transform.rotation);
        tmpGO.GetComponent<Rigidbody>().AddForce(forceDirection,ForceMode.Impulse);
    }
}
