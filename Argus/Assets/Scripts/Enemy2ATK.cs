using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy2ATK : MonoBehaviour
{
    private float frames = 5;
    void Awake()
    {
        transform.Rotate(90, 0, 0);
        Movement.health -= 2;
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