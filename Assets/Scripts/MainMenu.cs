using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int IndexScene)
    {
        SceneManager.LoadScene(IndexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown("escape") == true)
        {
            ExitGame();
        }
    }
}
