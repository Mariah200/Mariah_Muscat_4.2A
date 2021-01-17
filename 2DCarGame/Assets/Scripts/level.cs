using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void LoadStartMenu()
    {

        SceneManager.LoadScene(0); //loads the first scene rather then the game 
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("2D Car Game"); //loads the name of the game 
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver"); //When Game is over 
    }

    public void QuitGame()
    {
        Application.Quit(); //to quite 
    }
}

