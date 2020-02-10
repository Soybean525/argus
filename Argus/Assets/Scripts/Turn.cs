using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    private Quaternion camRotation;
    private Camera cam;
    private void Start()
    {
        cam = Camera.main;
        camRotation = cam.transform.rotation;
    }
    private void Update()
    {
        
            if (Input.GetAxis("Vertical") < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                cam.transform.rotation = camRotation;
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                cam.transform.rotation = camRotation;
            }
            else
            {
                transform.rotation = transform.rotation;
                cam.transform.rotation = camRotation;
            }
       

            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
                cam.transform.rotation = camRotation;
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                transform.eulerAngles = new Vector3(0, 270, 0);
                cam.transform.rotation = camRotation;
            }
            else
            {
                transform.rotation = transform.rotation;
                cam.transform.rotation = camRotation;
            }
    }
}
