using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed = 1;
    private float cooldown;
    public Transform other;
    public GameObject enemy2attack;
    private int health = 2;
    private void Awake()
    {
        other = GameObject.Find("Wolf").transform;
    }
    void Update()
    {
        if (cooldown < 1)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Vector3.Distance(other.position, transform.position) < 3 && cooldown < 1)
        {
            Instantiate(enemy2attack, transform.TransformPoint(Vector3.forward), transform.rotation);
            cooldown = 1.5f;
        }
        print(Vector3.Distance(other.position, transform.position));
        if (cooldown > -5)
        {
            cooldown -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ChainBox(Clone)")
        {
            health--;
            if (health < 1)
			{
				PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") - 1);
				Destroy(gameObject);
            }
        }
    }
}
