using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;
   
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0"); 
    }
}
