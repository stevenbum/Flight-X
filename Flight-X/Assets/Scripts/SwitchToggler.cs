using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class SwitchHandler : MonoBehaviour{
  private int switchState = 1;
  public GameObject switchBtn;
  public AudioManager audioManager;
  
  public void OnSwitchButtonClicked(){
        if (switchBtn != null) {
            Debug.Log("Switch button is not null, proceeding with animation...");
            switchBtn.transform.DOLocalMoveX(-switchBtn.transform.localPosition.x,0.2f);
            switchState = Math.Sign(-switchBtn.transform.localPosition.x);
        }
        else {
           Debug.LogError("switchBtn is not assigned. Please assign it in the Unity Editor.");
        }

        //Toggle music mute based on switch state
        audioManager.ToggleMusicMute(switchState == -1);
        Debug.Log("Switch state: " + switchState);
  }

}