﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int RotateSpeed;

    void Update()
    {
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }
}
