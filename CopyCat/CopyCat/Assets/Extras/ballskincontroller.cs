using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballskincontroller : MonoBehaviour
{
    //public static int ballchange;
    public GameObject originalball;
    public GameObject jagu;
    public GameObject champ;
    public GameObject comben;
    public GameObject skeleton;
    public GameObject dna;

    void Awake()
    {
        PlayerPrefs.GetInt("ballch");
        if (PlayerPrefs.GetInt("ballch") == 12)
        {
            jagu.SetActive(true);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(false);
            skeleton.SetActive(false);
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("ballch") == 13)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(true);
            skeleton.SetActive(false);
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("ballch") == 14)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(true);
            comben.SetActive(false);
            skeleton.SetActive(false);
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("ballch") == 15)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(false);
            skeleton.SetActive(true);
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("ballch") == 16)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(false);
            skeleton.SetActive(false);
            dna.SetActive(true);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
    }
}
