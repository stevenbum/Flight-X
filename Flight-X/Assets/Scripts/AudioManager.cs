using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource musicSource;
    private SwitchHandler switchtoggleScript;
    private void Start()
    {
        musicSource = GetComponent<AudioSource>();

    }

    public void ToggleMusicMute(bool mute)
    {
        switchtoggleScript.OnSwitchButtonClicked();
        musicSource.mute = mute;
        Debug.Log("Music muted: " + mute);
    }
}
