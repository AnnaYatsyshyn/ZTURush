using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene 1", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("Вихід");
        Application.Quit();
    }
}
