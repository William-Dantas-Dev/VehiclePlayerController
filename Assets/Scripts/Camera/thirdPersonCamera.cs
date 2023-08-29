using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {

    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
