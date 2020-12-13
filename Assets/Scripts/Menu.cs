using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    
        public void PlayGame()
        {
        Debug.Log("play");
        SceneManager.LoadScene("Solarsystem");
       

        }
    public void QuitGame()
    {

        Application.Quit();
    }
        
    }
