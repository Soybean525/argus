using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    private void Start()
    {
        if (GameObject.Find("Wolf") != null)
        {
            target = GameObject.Find("Wolf").transform;
        }
    }
    void Update()
    {
        transform.LookAt(target);
    }
}
