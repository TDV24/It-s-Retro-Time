using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class SettingsMenu : MonoBehaviour
{
   // FileInfo[] audioFiles = getAudioFiles();

    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
