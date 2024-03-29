using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class MusicDropdown : MonoBehaviour
{
    string[] audioFiles = new string[] { "Ocean_Drive", "Party_Rock", "Retro_Funk", "RocknRoll" };
    [SerializeField] AudioClip[] audioClips;
    MusicManager musicManager;

    [SerializeField] TMP_Text label;
    void Awake()
    {
        TMP_Dropdown dropdown = transform.GetComponent<TMP_Dropdown>();
        dropdown.options.Clear();

        foreach (string song in audioFiles)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = song });
        }

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelect(dropdown); });
    }

    private void DropdownItemSelect(TMP_Dropdown dropdown)
    {
        musicManager = FindObjectOfType<MusicManager>();
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
        label.text = newSongName;
    }
}

