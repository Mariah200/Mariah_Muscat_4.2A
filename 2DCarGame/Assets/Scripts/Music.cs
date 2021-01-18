using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake() //it runs before Start() //the singletle is loaded before starting the game 
    {
        SetUpSingleton();
    }
    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            //Do not destroy the MusicPlayer gameObject when changing scenes
            DontDestroyOnLoad(gameObject); //it will protect the music player, so it won't be destroyed when changing one scene to an another.
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
