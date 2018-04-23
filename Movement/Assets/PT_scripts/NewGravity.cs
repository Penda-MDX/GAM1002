using UnityEngine;

public class NewGravity : MonoBehaviour
{
    [SerializeField]
    float gravityValue = 9.81F;

    [SerializeField]
    float gForce;

    public float groundY { get; private set; }

    private void Update()
    {
        //print(IsGrounded());

        if(IsGrounded())
        {
            gForce = 0;
        }
        else
        {
            gForce += gravityValue * Time.deltaTime;
        }

        //transform.Translate(Vector3.down * gForce * Time.deltaTime);
    }

    public bool IsGrounded ()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(new Ray(transform.position, Vector3.down), out hitInfo, 1F))
        {
            if(hitInfo.collider.tag == "Ground" || hitInfo.collider.tag == "Platform")
            {
                groundY = hitInfo.collider.transform.position.y;
                return true;
            }
        }
        return false;
    }

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