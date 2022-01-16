using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float verticalForce = 50f;
    public float downwardsForce = 800f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, -downwardsForce * Time.deltaTime, 0);

         if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("left") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("right") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       
        if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }

    void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0, ForceMode.Impulse);
        }

         if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, -verticalForce * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(0, -verticalForce * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
} 


