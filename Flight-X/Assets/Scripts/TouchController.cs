using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public FixedTouchField _FixedTouchField;
    public CameraLook _CameraLook;
    public PlayerMovement _PlayerMovement;
    public FixedButton _FixedButton;
    void Start()
    {
        
    }

    
    void Update()
    {
        _CameraLook.LockAxis = _FixedTouchField.TouchDist;
        _PlayerMovement.Pressed =_FixedButton.Pressed;
    }
}
