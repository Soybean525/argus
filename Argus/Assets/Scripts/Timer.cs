using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeleft = 300;
    public GameObject failscreen;
    void Update()
    {
        timeleft -= Time.deltaTime;
        print(timeleft);
        if (timeleft <= 0)
        {
            Instantiate(failscreen);
        }
    }
}
