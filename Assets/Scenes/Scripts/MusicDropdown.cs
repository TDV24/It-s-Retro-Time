using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicDropdown : MonoBehaviour
{
    void Awake()
    {
        TMP_Dropdown dropdown = transform.GetComponent<TMP_Dropdown>();

        string[] audioFiles = getAudioFiles();
        char[] delimiterChars = { '/', '\\' };
        dropdown.options.Clear();

        foreach (string song in audioFiles)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = System.IO.Path.GetFileName(song) });
        }
    }

    private string[] getAudioFiles()
    {
        string path = Application.dataPath + "/Music/AudioFiles";
        string[] filePaths = System.IO.Directory.GetFiles(@path, "*.mp3");

        foreach (string file in filePaths)
        {
            Debug.Log(file);
        }

        return filePaths;
    }
}
