using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeath : MonoBehaviour
{
    public int frames;
    void Update()
    {
        frames--;
        if(frames <= 0)
        {
            Destroy(gameObject);
        }
    }
}
