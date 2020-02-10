using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoKiller : MonoBehaviour
{
    public GameObject canvas;
    private int timer;
    void Update()
    {
        timer++;
        if (timer >= 27 * 60)
        {
            canvas.SetActive(true);
            Destroy(gameObject);
        }
    }
}
