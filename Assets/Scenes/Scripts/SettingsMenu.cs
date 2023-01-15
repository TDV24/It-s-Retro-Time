using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private float startVolume;

    private void Start()
    {
        startVolume = PlayerPrefs.GetFloat("volume");
        audioMixer.SetFloat("volume",startVolume);
    }
    public void SetVolume (float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
        audioMixer.SetFloat("volume", volume);
    }
}
