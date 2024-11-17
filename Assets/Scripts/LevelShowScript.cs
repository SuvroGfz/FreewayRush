using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelShowScript : MonoBehaviour
{
    public Text level;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Final Level 1")
        {
            level.text = "This is Level 1";
        }
        else if (SceneManager.GetActiveScene().name == "Final Level 2")
        {
            level.text = "This is Level 2";
        }
        else if (SceneManager.GetActiveScene().name == "Final Level 3")
        {
            level.text = "This is Level 3";
        }
        else if (SceneManager.GetActiveScene().name == "Final Level 4")
        {
            level.text = "This is Level 4";
        }
    }
}
