using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip JumpSound;
    public static AudioClip ScoreSound;
    public static AudioClip GameOver;
    public static AudioSource audioSrc;  



    void Start()
    {

        JumpSound = Resources.Load<AudioClip>("Jump");
        ScoreSound = Resources.Load<AudioClip>("Score");
        GameOver = Resources.Load<AudioClip>("GameOver");
        audioSrc = GetComponent<AudioSource>();
    }





    public static void playSound(string Clip)
    {

        switch (Clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;

            case "Score":
                audioSrc.PlayOneShot(ScoreSound);
                break;
        }
    }
}