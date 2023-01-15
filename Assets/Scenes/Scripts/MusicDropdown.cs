using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class MusicDropdown : MonoBehaviour
{
    string[] audioFiles;
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] MusicManager musicManager;
    void Awake()
    {
        TMP_Dropdown dropdown = transform.GetComponent<TMP_Dropdown>();
        audioFiles = getAudioFiles();

        char[] delimiterChars = { '/', '\\'};
        dropdown.options.Clear();

        foreach (string song in audioFiles)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = System.IO.Path.GetFileName(song).Replace(".mp3", "") });
        }

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelect(dropdown); });
    }

    private void DropdownItemSelect(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;
        string newSongName = dropdown.options[index].text;

        switch (newSongName)
        {
            case "Ocean_Drive":
                musicManager.ChangeBGM(audioClips[0]);
                break;
            case "Party_Rock":
                musicManager.ChangeBGM(audioClips[1]);
                break;
            case "Retro_Funk":
                musicManager.ChangeBGM(audioClips[2]);
                break;
            case "RocknRoll":
                musicManager.ChangeBGM(audioClips[3]);
                break;
            default:
                musicManager.ChangeBGM(audioClips[0]);
                break;
        }
    }

    private string[] getAudioFiles()
    {
        string path = Application.dataPath + "/Music/AudioFiles";
        string[] filePaths = System.IO.Directory.GetFiles(@path, "*.mp3");

        return filePaths;
    }
}

