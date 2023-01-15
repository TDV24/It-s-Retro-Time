
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;

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
            BGM = GetComponent<AudioSource>();
        }
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}
