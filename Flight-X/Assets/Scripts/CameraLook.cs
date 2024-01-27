using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private float XMove; 
    private float YMove;
    private float XRotation;
    [SerializeField] private Transform PlayerBody;
    public Vector2 LockAxis;
    public float Sensitivity = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XMove = LockAxis.x *Time.deltaTime;
        YMove = LockAxis.y * Time.deltaTime;
        XRotation -= YMove;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        PlayerBody.Rotate(Vector3.up * XMove);
    }
}
