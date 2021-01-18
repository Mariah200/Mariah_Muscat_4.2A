using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField] float delayInSec = 2f;

    IEnumerator WandL() //these are co routines (Wait and load)
    {
        yield return new WaitForSeconds(delayInSec);
        SceneManager.LoadScene("GameOver");
    }
    public void LoadStartMenu()
    {

        SceneManager.LoadScene(0); //loads the first scene rather then the game 
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("2DCarScene"); //loads the 2DCar Scene of the game 
    }

    public void LoadGameOver()
    {
        StartCoroutine(WandL());
    }

    public void QuitGame()
    {
        Application.Quit(); //to quite 
    }
}

