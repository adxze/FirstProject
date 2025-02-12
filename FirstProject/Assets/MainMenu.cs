using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator animator;
    public void startGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void endGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void mainGame()
    {
        SceneManager.LoadSceneAsync(0);

    }
    public void attack()
    {
        animator.SetBool("boolattack", true);
        animator.SetTrigger("triggerattack");
        
    }

}
