using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTemp : MonoBehaviour
{
    public void GoBack()
    {
            SceneManager.UnloadSceneAsync(5);
            Time.timeScale = 1.0f;
    }
}
