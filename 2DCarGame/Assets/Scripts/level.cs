using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField] float delayInSec = 1f;
    

    public void LoadStartMenu()
    {

        SceneManager.LoadScene(0); //loads the first scene rather then the game 
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("2DCarScene"); //loads the 2DCar Scene of the game 

        FindObjectOfType<GameSession>().ResetGame(); //To reset the game 
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
       
    }

    public void QuitGame()
    {
        Application.Quit(); //to quite 
    }
}

