using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    Resolution[] resolutions;

    void Start () {
        resolutions = Screen.resolutions;
    }

    public void SetVolume (float volume) {
        audioMixer.SetFloat("menuVolume", volume);
    }

    public void SetResolution (float value) {
        int v = (int)value;
        Resolution resolution = resolutions[21];
        switch (v) {
            case 0: 
                resolution = resolutions[5]; break;
            case 1:
                resolution = resolutions[11]; break;
            case 2:
                resolution = resolutions[21]; break;
        }
        // Debug.Log(resolution);
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetEffect (float effectVolume) {
        audioMixer.SetFloat("effectsVolume", effectVolume);
    }

    public void SetFullScreen (bool isFullScreen) {
        Debug.Log(isFullScreen);
        Screen.fullScreen = isFullScreen;
    }
}
