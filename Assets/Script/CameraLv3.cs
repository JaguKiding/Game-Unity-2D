using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLv3 : MonoBehaviour
{
    public Transform TargetCamera;
    public float SmoothSpeed;
    public Vector3 Offset;

    void Start()
    {

    }
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -0.38f, 94.34f),
        Mathf.Clamp(transform.position.y, -12.3f, 4.08f),
        transform.position.z);
    }

    private void FixedUpdate()
    {
        Vector3 positioncamera = TargetCamera.localPosition + Offset;
        Vector3 smoothCamera = Vector3.Lerp(transform.position, positioncamera, SmoothSpeed);
        transform.position = smoothCamera;
    }
}
