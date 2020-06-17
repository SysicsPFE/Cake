using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModesManager : MonoBehaviour
{
    public static string Mode ="Endless";
    public GameObject Modes;

    public void Endless()
    {
        Mode = "Endless";
        Debug.Log(Mode);
        SceneManager.LoadScene("Game");
    }
    public void Timer()
    {
        Mode = "Timer";
        Debug.Log(Mode);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Speed()
    {
        Mode = "Speed";
        Debug.Log(Mode);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void BackMenu()
    {
       Modes.SetActive(false);
        
    }
    
}
