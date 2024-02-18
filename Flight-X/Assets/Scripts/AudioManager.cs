using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource musicSource;
    private SwitchToggler switchtoggleScript;
    private void Start()
    {
        musicSource = GetComponent<AudioSource>();


    }

    public void ToggleMusicMute(bool mute)
    {
        musicSource.mute = mute;
        Debug.Log("Music muted: " + mute);
    }
}
