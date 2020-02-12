using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private int frames = 10;
    void Awake()
    {
        transform.Rotate(90, Attack.aim, 0);
    }

    // Update is called once per frame
    void Update()
    {
        frames -= 1;
    }
    private void LateUpdate()
    {
        if (frames <= 1)
        {
            Destroy(gameObject);
        }
    }
}
