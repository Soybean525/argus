using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float Speed = 6;
    public static int health = 5;
    public GameObject healthdisplay;
    public Sprite Healthbar1;
    public Sprite Healthbar2;
    public Sprite Healthbar3;
    public Sprite Healthbar4;
    public Sprite Healthbar5;

    private void Awake()
    {
        health = 5;
    }
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Death");
        }
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
        transform.Translate(0, 0, -Speed * Time.deltaTime);
        }
        //transform.Translate(Mathf.Abs(Input.GetAxis("Horizontal")) * Time.deltaTime * Speed, 0, Mathf.Abs(Input.GetAxis("Vertical")) * Time.deltaTime * Speed);
        print(healthdisplay);
        if (health == 5)
        {
            healthdisplay.GetComponent<SpriteRenderer>().sprite = Healthbar1;
        }
        else if (health == 4)
        {
            healthdisplay.GetComponent<SpriteRenderer>().sprite = Healthbar2;
        }
        else if (health == 3)
        {
            healthdisplay.GetComponent<SpriteRenderer>().sprite = Healthbar3;
        }
        else if (health == 2)
        {
            healthdisplay.GetComponent<SpriteRenderer>().sprite = Healthbar4;
        }
        else if (health == 1)
        {
            healthdisplay.GetComponent<SpriteRenderer>().sprite = Healthbar5;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
