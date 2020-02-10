using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public static int aim;
    public Chain wack;
    void Update()
    {
        if (Input.GetAxis("HorizontalATK") != 0 && Input.GetAxis("VerticalATK") != 0)
        {
            if (Input.GetAxis("HorizontalATK") == 1 && Input.GetAxis("VerticalATK") == 1)
            {
                aim = 45;
            }
            else if (Input.GetAxis("HorizontalATK") == 1 && Input.GetAxis("VerticalATK") == -1)
            {
                aim = 135;
            }
            else if (Input.GetAxis("HorizontalATK") == -1 && Input.GetAxis("VerticalATK") == -1)
            {
                aim = 225;
            }
            else if (Input.GetAxis("HorizontalATK") == -1 && Input.GetAxis("VerticalATK") == 1)
            {
                aim = 315;
            }
        }
        else if (Input.GetAxis("HorizontalATK") != 0 || Input.GetAxis("VerticalATK") != 0)
        {
            if (Input.GetAxis("HorizontalATK") == -1)
            {
                aim = 270;
            }
            else if (Input.GetAxis("HorizontalATK") == 1)
            {
                aim = 90;
            }
            else if (Input.GetAxis("VerticalATK") == -1)
            {
                aim = 180;
            }
            else if (Input.GetAxis("VerticalATK") == 1)
            {
                aim = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(wack, transform.position, Quaternion.identity);
        }
    }
}