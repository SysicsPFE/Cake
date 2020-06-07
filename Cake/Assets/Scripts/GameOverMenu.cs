using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    public GameObject GameOver_Menu;
   

    

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOver_Menu.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        
    }
}
