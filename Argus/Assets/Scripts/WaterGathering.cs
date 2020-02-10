using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterGathering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("waterlevel", 0);
        PlayerPrefs.SetInt("watergotten", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("watergotten") == 4)
        {
            SceneManager.LoadScene("Win");
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "water" && PlayerPrefs.GetInt("waterlevel") == 0)
        {
            PlayerPrefs.SetInt("waterlevel", 1);
            Destroy(other.gameObject);
        }
        else if (other.tag == "waterperson" && PlayerPrefs.GetInt("waterlevel") == 1)
        {
            PlayerPrefs.SetInt("watergotten", PlayerPrefs.GetInt("watergotten") + 1);
            PlayerPrefs.SetInt("waterlevel", 0);
        }
    }
}
