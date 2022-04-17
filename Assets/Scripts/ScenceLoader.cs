using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour
{
    public void LoadNextScence()
    {
        int CurrentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScenceIndex + 1);

    }
    public void LoadStartScence()
    {

        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
