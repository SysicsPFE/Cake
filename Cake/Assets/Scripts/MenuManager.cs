using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public int CoinValue = 0;
    public TextMeshProUGUI CoinText;
    public GameObject Shop;
    public GameObject Modes;
    public GameObject Settings;

    void Start()
    {
        
        CoinText.text = CoinValue.ToString();
        

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void PlayShop()
    {
        Shop.SetActive(true);
    }
    /*public void PlayModes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }*/
    public void PlayMode()
    {
        Modes.SetActive(true);
    }
    public void PlaySettings()
    {
        Settings.SetActive(true);
    }
        
        
}
