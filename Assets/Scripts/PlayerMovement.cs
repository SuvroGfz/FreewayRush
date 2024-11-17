
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi! Let us begin");
        if (SceneManager.GetActiveScene().name == "Final Level 1")
        {
            
        }
        else if (SceneManager.GetActiveScene().name == "Final Level 2")
        {
            
        }

        rb.AddForce(0,0,200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rb.velocity.z < 40)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Acceleration);
        }

        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        

    }
}
