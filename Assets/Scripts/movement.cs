using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float maxVelocityForward = 30;
    public float maxVelocityBackward = 20;

    

    public float obstacleForce = 2000f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0,0, -200,ForceMode.Acceleration);
        if(SceneManager.GetActiveScene().name == "Final Level 1")
        {
            maxVelocityForward = 20;
            maxVelocityBackward = 15;
        }
        else if(SceneManager.GetActiveScene().name == "Final Level 2")
        {
            maxVelocityForward = 19;
            maxVelocityBackward = 18;
        }
        else if(SceneManager.GetActiveScene().name == "Final Level 3")
        {
            maxVelocityForward = 18;
            maxVelocityBackward = 20;
        }
        else if(SceneManager.GetActiveScene().name == "Final Level 4")
        {
            maxVelocityForward = 17;
            maxVelocityBackward = 22;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rb.velocity.z < maxVelocityForward && rb.velocity.z > -maxVelocityBackward)
        {
            rb.AddForce(0, 0, -obstacleForce * Time.deltaTime, ForceMode.Acceleration);
        }
           

    }
}
