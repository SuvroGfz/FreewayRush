using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public bool decreaseScore = false;
    public Text gameOver;
    
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name);

        if(collision.collider.tag == "Obstacles")
        {
            Debug.Log("obstacle collision");
            movement.enabled = false;
            gameOver.enabled = true;

            FindObjectOfType<GameManager>().EndGame();

        }
        if (collision.collider.tag == "Heavy")
        {
            //Debug.Log(collision.rigidbody.velocity.z);

            {
                movement.enabled = false;
                gameOver.enabled = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        if(transform.position.y > 2)
        {
            movement.enabled = false;
            gameOver.enabled = true;
            FindObjectOfType<GameManager>().EndGame();
        }
        decreaseScore = true;

        //if(transform.rotation.eulerAngles.z  > -70 || transform.rotation.eulerAngles.z  < -110)
        {
            //movement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
            //Debug.Log(transform.rotation.eulerAngles.z);
        }
        
    }
}
