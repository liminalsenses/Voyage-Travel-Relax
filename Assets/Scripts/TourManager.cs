﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{

    public delegate void SetCameraPositionHandler(Vector3 position, Vector3 direction);
    public static SetCameraPositionHandler SetCameraPosition;

    public Transform Camera;

    private void OnEnable()
    {
        SetCameraPosition += SetCamera;
    }

    private void OnDisable()
    {
        SetCameraPosition -= SetCamera;
    }

    public void SetCamera(Vector3 position, Vector3 direction)
    {
        Camera.position = position;
        Camera.LookAt(direction);
    }
   
}
