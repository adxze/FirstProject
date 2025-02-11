using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void endGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
