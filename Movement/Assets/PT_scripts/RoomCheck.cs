using UnityEngine;

public class RoomCheck : MonoBehaviour
{
 
    public string ThisRoomName ()
    {
        RaycastHit[] hitInfo = Physics.RaycastAll(transform.position, Vector3.down, 10F);

        foreach(RaycastHit h in hitInfo)
        {
            if(h.collider.tag != "Ground")
            {
                continue;
            }
            return h.collider.name;
        }
        return "";
    }
}