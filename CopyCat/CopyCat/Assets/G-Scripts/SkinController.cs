using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinController : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("boxskin") == 90)
        {
            rend.sharedMaterial = material[1];
        }

        if (PlayerPrefs.GetInt("boxskin") == 91)
        {
            rend.sharedMaterial = material[2];
        }

        if (PlayerPrefs.GetInt("boxskin") == 92)
        {
            rend.sharedMaterial = material[3];
        }

        if (PlayerPrefs.GetInt("boxskin") == 93)
        {
            rend.sharedMaterial = material[4];
        }

        if (PlayerPrefs.GetInt("boxskin") == 94)
        {
            rend.sharedMaterial = material[5];
        }

        if (PlayerPrefs.GetInt("boxskin") == 95)
        {
            rend.sharedMaterial = material[6];
        }

        if (PlayerPrefs.GetInt("boxskin") == 96)
        {
            rend.sharedMaterial = material[7];
        }

        if (PlayerPrefs.GetInt("boxskin") == 97)
        {
            rend.sharedMaterial = material[8];
        }
    }
}
