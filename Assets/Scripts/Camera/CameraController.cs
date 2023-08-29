using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private firstPersonCamera firstPersonCamera;
    private thirdPersonCamera thirdPersonCamera;
    private float cameraIndex;
    void Start()
    {
        firstPersonCamera = GetComponent<firstPersonCamera>();
        thirdPersonCamera = GetComponent<thirdPersonCamera>();
        if(cameraIndex == 0)
        {
            firstPersonCamera.enabled = false;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            if(cameraIndex == 0)
            {
                cameraIndex = 1;
                thirdPersonCamera.enabled = false;
                firstPersonCamera.enabled = true;
            }else if(cameraIndex == 1)
            {
                cameraIndex = 0;
                thirdPersonCamera.enabled = true;
                firstPersonCamera.enabled = false;
            }
        }
    }
}
