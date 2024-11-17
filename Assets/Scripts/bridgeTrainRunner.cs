using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeTrainRunner : MonoBehaviour
{
    public Rigidbody rb;
    public bool forward = true;
    public float speedofTrain = 2000f;
    public float maxTrainSpeed = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, -200, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.z < maxTrainSpeed && forward == true)
        {
            rb.AddForce(0, 0, speedofTrain * Time.deltaTime, ForceMode.Acceleration);
        }
        else if (rb.velocity.z > -maxTrainSpeed && forward == false)
        {
            rb.AddForce(0, 0, -speedofTrain * Time.deltaTime, ForceMode.Acceleration);
        }
    }
}
