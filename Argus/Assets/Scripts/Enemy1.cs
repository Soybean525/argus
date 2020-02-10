using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float speed = 1;
    private float cooldown;
    public Transform other;
    public GameObject enemy1attack;
    private void Awake()
    {
        other = GameObject.Find("Wolf").transform;
    }
    void Update()
    {
        if (Vector3.Distance(other.position, transform.position) < 9 && cooldown < 1)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Vector3.Distance(other.position, transform.position) < 4.5 && cooldown < 1)
        {
            Instantiate(enemy1attack, transform.TransformPoint(Vector3.forward), transform.rotation);
            cooldown = 1.5f;
        }
        if (cooldown > -5)
        {
            cooldown -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ChainBox(Clone)")
        {
            PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") - 1);
            Destroy(gameObject);
        }
    }
}