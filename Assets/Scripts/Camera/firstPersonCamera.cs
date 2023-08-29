using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonCamera : MonoBehaviour
{
    public GameObject player;
    public Transform position;
    void Start()
    {

    }
    void LateUpdate()
    {
        transform.position = position.position;
        transform.rotation = player.transform.rotation;
    }
}
