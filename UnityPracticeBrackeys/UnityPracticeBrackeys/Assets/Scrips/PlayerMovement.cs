
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //THis is a reference to the RIgidbody component called rb
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start () {

    }

    //Marked FixedUpdate because we are using it to mess with physics
    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a forward force to z axis

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(500 * Time.deltaTime, 0, 0);
        //}

    }
}
