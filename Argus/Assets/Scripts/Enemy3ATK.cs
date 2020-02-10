using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3ATK : MonoBehaviour
{
    private float frames = 5;
    void Awake()
    {
        transform.Rotate(90, 0, 0);
        Movement.health -= 3;
    }
    void Update()
    {
        frames--;
    }
    private void LateUpdate()
    {
        if (frames < 1)
        {
            Destroy(gameObject);
        }
    }
}