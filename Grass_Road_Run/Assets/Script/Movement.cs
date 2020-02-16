using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    

    void Start()
    {
       
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (Input.GetKey("s"))
        {
            rb.MovePosition(new Vector3(-1, 0, 0));
            //rb.velocity = new Vector3(0, speed, speed);
        }
        else if (Input.GetKey("a"))
        {
            rb.MovePosition(new Vector3(transform.position.x -1,transform.position.y, transform.position.z));
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if (Input.GetKey("d"))
        {
            rb.MovePosition(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z));
            rb.velocity = new Vector3(0, 0, speed);
            //rb.velocity = new Vector3(speed, 0, speed);
        }

    }
}
