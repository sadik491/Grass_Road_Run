using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;
    public float speed;
    float move = 1;
    

    void Start()
    {
       
    }

    
    void FixedUpdate()
    {
        ControlPlayer();

    }

    private void ControlPlayer()
    {
        if (Input.GetKey("w"))
        {
            anim.SetTrigger("Run");
            rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            //rb.MovePosition(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z));
            //rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            //rb.MovePosition(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z));
            //rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }
}
