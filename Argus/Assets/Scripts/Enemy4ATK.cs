using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4ATK : MonoBehaviour
{
    public float speed = 1;
    void Awake()
    {
        transform.LookAt(GameObject.Find("Wolf").transform);
        transform.Translate(0, 0, .5f);
        transform.Rotate(-90, 0, 0);
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime * -1, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Movement.health -= 3;
        }
        Destroy(gameObject);
    }
}
