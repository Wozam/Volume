using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System.Linq;

public class AudioManager : MonoBehaviour {
    public AudioSource source;
    public static AudioManager instance;

    bool playing = false;

    void Awake() {
        if(instance != null) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start() {
        if(!PlayerPrefs.HasKey("volume")) {
            PlayerPrefs.SetFloat("volume", 1);
        } else {
            load();
        }
    }

    public void Volume (float volume) {
        AudioListener.volume = volume;

        PlayerPrefs.SetFloat("volume", volume);
    }

    void load () {
        PlayerPrefs.GetFloat("volume");
    }
}
