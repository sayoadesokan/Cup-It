using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausecontroller : MonoBehaviour
{
    public GameObject originalball;
    public GameObject jagu;
    public GameObject champ;
    public GameObject comben;
    public GameObject skeleton;
    public GameObject dna;
    public GameObject obstacle;
    public GameObject cup;
    public void presspause()
    {
        originalball.SetActive(false);
        obstacle.SetActive(false);
        cup.SetActive(false);

        if (PlayerPrefs.GetInt("ballch") == 12)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(false);
            skeleton.SetActive(false);
            dna.SetActive(false);
            obstacle.SetActive(false);
            cup.SetActive(false);
        }
        if (PlayerPrefs.GetInt("ballch") == 13)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
            comben.SetActive(false);
            skeleton.SetActive(false);
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("ballch") == 14)
        {
            jagu.SetActive(false);
            originalball.SetActive(false);
            champ.SetActive(false);
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
            skeleton.SetActive(false);
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
            dna.SetActive(false);
            //PlayerPrefs.GetInt("ballch", ballchange);
            PlayerPrefs.Save();
        }
    } 
}
