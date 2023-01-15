using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicDropdown : MonoBehaviour
{
    void Awake()
    {
        /*        Transform child = transform.Find("Dropdown");
                Debug.Log(child.name);*/
        /*        foreach (Transform child in transform)
        {
                    Debug.Log(child.GetType());
                }*/

        Dropdown dropdown = transform.GetComponent<Dropdown>();
        Debug.Log(dropdown.name);

        string[] audioFiles = getAudioFiles();
        char[] delimiterChars = { '/', '\\' };
        dropdown.options.Clear();

        foreach (string song in audioFiles)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = System.IO.Path.GetFileName(song) });
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
