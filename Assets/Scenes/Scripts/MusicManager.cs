using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    static AudioSource BGM;

    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundMusic");

        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public static void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;

        BGM.Play();
    }
}
