using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image TimerBar;
    public static float maxTime = 50f;
    public static float timeLeft;
    public GameObject GameOver_Menu;

    void Start()
    {
        TimerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            TimerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            GameOver_Menu.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
