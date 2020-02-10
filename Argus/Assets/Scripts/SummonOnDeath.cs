using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonOnDeath : MonoBehaviour
{
    public GameObject summon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Instantiate(summon);
    }
}
