using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStarter : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        SceneManager.LoadScene(1);
    }
    public void GoToHelpPage()
    {
        SceneManager.LoadScene("Help Scene");
    }
    public void GoToCreditsPage()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
