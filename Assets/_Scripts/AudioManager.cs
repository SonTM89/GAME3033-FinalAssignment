using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGMSources;

    public static AudioManager instance;

    public static bool playBGM;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        BGMSources.Play();
        playBGM = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(playBGM == false)
        {
            if (SceneManager.GetActiveScene().name == "MainMenuScene" || SceneManager.GetActiveScene().name == "TrackSelectScene")
            {
                BGMSources.Play();
                playBGM = true;
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name != "MainMenuScene" && SceneManager.GetActiveScene().name != "TrackSelectScene")
            {
                BGMSources.Stop();
                playBGM = false;
            }
        } 
    }
}
