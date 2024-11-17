using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainMover : MonoBehaviour
{
    public Rigidbody player;
    public Rigidbody train;
    public float trainForce = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        train.AddForce(200, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(train.velocity.x < 40)
            train.AddForce(trainForce, 0, 0);
        
    }
}
