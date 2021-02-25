using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintCameraMove : MonoBehaviour
{
    public CinemachineConfiner camera;
    public Collider2D collider2;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            camera.m_BoundingShape2D = collider2;
        }
    }
}
