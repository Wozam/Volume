using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VolumeManager : MonoBehaviour {
    public Slider slider;

    void Start() {
        if(!PlayerPrefs.HasKey("volume")) {
            PlayerPrefs.SetFloat("volume", 1f);
        } else {
            load();
        }

        AudioManager.instance.Volume(slider.value);
        slider.onValueChanged.AddListener(val => AudioManager.instance.Volume(val));
    }

    void VolumeChange() {
        PlayerPrefs.SetFloat("volume", slider.value);
    }

    void load() {
        slider.value = PlayerPrefs.GetFloat("volume");
    }
}
