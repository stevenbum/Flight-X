using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void GotoInstructionsMenu()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }
    public void GotoAboutMenu()
    {
        SceneManager.LoadScene("AboutMenu");
    }
    public void GotoOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
