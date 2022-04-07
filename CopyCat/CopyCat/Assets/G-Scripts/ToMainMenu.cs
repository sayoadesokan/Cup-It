using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    public GameObject[] gameobjectsagain;
    public void Update()
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

    public void MainMove()
    {
        SceneManager.LoadScene(1);
        Touch1.limit = 0;
    }
}
