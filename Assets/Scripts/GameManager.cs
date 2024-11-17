using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float delaytime = 2f;

    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        Debug.Log("level complete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over babe!");
            Invoke("Restart", delaytime);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

}
