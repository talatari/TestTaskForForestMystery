using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int _indexScene)
    {
        SceneManager.LoadScene(_indexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            ExitGame();
        }
    }


}