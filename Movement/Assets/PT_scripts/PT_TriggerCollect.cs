using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_TriggerCollect : MonoBehaviour
{
    public List<string> tagsCollectedBy;

    private void OnTriggerEnter(Collider other)
    {
        foreach(string collectorTag in tagsCollectedBy)
        {
            if (other.gameObject.tag == collectorTag)
            {
                other.gameObject.SendMessage("Collected", null, SendMessageOptions.DontRequireReceiver);
                Destroy(gameObject);
                return;
            }
        }
    }

}
