using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelTranslate : MonoBehaviour
{
    public void SceneFirst(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1.0f;
    }

    public void SceneSecond(int sceneSecond)
    {
        SceneManager.LoadScene(sceneSecond);
        Time.timeScale = 1.0f;
    }

    public void SceneMenu(int sceneMenu)
    {
        SceneManager.LoadScene(sceneMenu);
        Time.timeScale = 1.0f;
    }
}
