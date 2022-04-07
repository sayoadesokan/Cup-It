using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivalpause : MonoBehaviour
{
    public GameObject[] gameobjectsagain;
    public static bool paused;
    void Start()
    {
        paused = false;
    }

    public void pause()
    {
        Time.timeScale = 0;
    }
    public void resume()
    {
        Time.timeScale = 1;
    }

    public void Presspause()
    {
        if (SurvivalEnd.snum == 1)
        {
            gameobjectsagain[0].SetActive(false);
        }
        if (SurvivalEnd.snum == 2)
        {
            gameobjectsagain[1].SetActive(false);
        }
        if (SurvivalEnd.snum == 3)
        {
            gameobjectsagain[2].SetActive(false);
        }
        if (SurvivalEnd.snum == 4)
        {
            gameobjectsagain[3].SetActive(false);
        }
        if (SurvivalEnd.snum == 5)
        {
            gameobjectsagain[4].SetActive(false);
        }
        if (SurvivalEnd.snum == 6)
        {
            gameobjectsagain[5].SetActive(false);
        }
        if (SurvivalEnd.snum == 7)
        {
            gameobjectsagain[6].SetActive(false);
        }
        if (SurvivalEnd.snum == 8)
        {
            gameobjectsagain[7].SetActive(false);
        }
    }

    public void pressresume()
    {
        if (SurvivalEnd.snum == 1)
        {
            gameobjectsagain[0].SetActive(true);
        }
        if (SurvivalEnd.snum == 2)
        {
            gameobjectsagain[1].SetActive(true);
        }
        if (SurvivalEnd.snum == 3)
        {
            gameobjectsagain[2].SetActive(true);
        }
        if (SurvivalEnd.snum == 4)
        {
            gameobjectsagain[3].SetActive(true);
        }
        if (SurvivalEnd.snum == 5)
        {
            gameobjectsagain[4].SetActive(true);
        }
        if (SurvivalEnd.snum == 6)
        {
            gameobjectsagain[5].SetActive(true);
        }
        if (SurvivalEnd.snum == 7)
        {
            gameobjectsagain[6].SetActive(true);
        }
        if (SurvivalEnd.snum == 8)
        {
            gameobjectsagain[7].SetActive(true);
        }
    }

    public void getcoin()
    {
        Hintandcoin.coinamount += 200;
    }
}
