using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_summoner : MonoBehaviour
{
    private float randomnum;

    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    private int timepass;
    void Start()
    {
        PlayerPrefs.SetInt("monsters", 0);
    }
    void Update()
    {
        timepass++;
        if (timepass % 3 == 0)
        {
            if (PlayerPrefs.GetInt("monsters") < 50)
            {
                randomnum = Random.value;
                if (randomnum < .25 || PlayerPrefs.GetInt("watergotten") == 0)
                {
                    Instantiate(E1, new Vector3((Random.value * 200) - 100, 10, (Random.value * 200) - 100), Quaternion.identity);
                    PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") + 1);
                }
                else if (randomnum < .5 || PlayerPrefs.GetInt("watergotten") == 1 && PlayerPrefs.GetInt("watergotten") > 0)
                {
                    Instantiate(E2, new Vector3((Random.value * 200) - 100, 10, (Random.value * 200) - 100), Quaternion.identity);
                    PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") + 1);
                }
                else if (randomnum < .75 || PlayerPrefs.GetInt("watergotten") == 2 && PlayerPrefs.GetInt("watergotten") > 1)
                {
                    Instantiate(E3, new Vector3((Random.value * 200) - 100, 10, (Random.value * 200) - 100), Quaternion.identity);
                    PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") + 1);
                }
                else if (randomnum <= 1 && PlayerPrefs.GetInt("watergotten") > 2)
                {
                    Instantiate(E4, new Vector3((Random.value * 200) - 100, 10, (Random.value * 200) - 100), Quaternion.identity);
                    PlayerPrefs.SetInt("monsters", PlayerPrefs.GetInt("monsters") + 1);
                }
            }
        }
    }
}
