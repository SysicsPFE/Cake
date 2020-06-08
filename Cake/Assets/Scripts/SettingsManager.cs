using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float slideValue)
    {
        mixer.SetFloat("MusicVol",Mathf.Log10(slideValue) * 20);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        GameManagerPartie.instance.highScore.text = "0";
    }
}
