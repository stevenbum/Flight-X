using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public void nextScene() 
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void playGame()
    {
        SceneManager.LoadScene("Level Modules");
    }
    public void gotoInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void backtoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quitGame ()
    {
        Application.Quit();
    }
}
