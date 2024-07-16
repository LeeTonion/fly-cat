using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("game");
    }
    
    public void Exitgame()
    {
        Application.Quit();
    }
   
}
