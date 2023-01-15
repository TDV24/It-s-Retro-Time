using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class MusicDropdown : MonoBehaviour
{
    string[] audioFiles;
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
        AudioClip clip;
        int index = dropdown.value;
        string newSongName = dropdown.options[index].text;

        foreach (string path in audioFiles)
        {
            if (path.Contains(newSongName))
            {
                WWW requestedAudio = LoadAudio(Application.dataPath + "/Music/AudioFiles/test/");
                clip = requestedAudio.GetAudioClip();
                Debug.Log(clip.name);
                MusicManager.ChangeBGM(clip);
            }
        }

        //Debug.Log(newSongName);

    }

    private string[] getAudioFiles()
    {
        string path = Application.dataPath + "/Music/AudioFiles";
        string[] filePaths = System.IO.Directory.GetFiles(@path, "*.mp3");

/*        foreach (string file in filePaths)
        {
            Debug.Log(file);
        }*/

        return filePaths;
    }

    private WWW LoadAudio(string path)
    {
        WWW requestedAudio = new WWW(path);

        return requestedAudio;
    }
}

