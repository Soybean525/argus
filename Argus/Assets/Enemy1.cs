﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float speed = 2;
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
