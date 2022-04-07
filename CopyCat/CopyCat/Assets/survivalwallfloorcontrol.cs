using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivalwallfloorcontrol : MonoBehaviour
{
    public GameObject[] wallandfloor;
    public GameObject endgameui;
    void Start()
    {
        wallandfloor[0].SetActive(true);
        wallandfloor[1].SetActive(false);
        wallandfloor[2].SetActive(false);
        wallandfloor[3].SetActive(false);
        //FindObjectOfType<AudioManager>().Play("Time");
    }

    void Update()
    {
        if(SurvivalEnd.snum == 1)
        {
            wallandfloor[0].SetActive(true);
            wallandfloor[1].SetActive(false);
            wallandfloor[2].SetActive(false);
            wallandfloor[3].SetActive(false);
        }
        if (SurvivalEnd.snum == 2)
        {
            wallandfloor[2].SetActive(true);
            wallandfloor[0].SetActive(false);
            wallandfloor[1].SetActive(false);
            wallandfloor[3].SetActive(false);
        }
        if (SurvivalEnd.snum == 3)
        {
            wallandfloor[1].SetActive(true);
            wallandfloor[0].SetActive(false);
            wallandfloor[2].SetActive(false);
            wallandfloor[3].SetActive(false);
        }
        if (SurvivalEnd.snum == 4)
        {
            wallandfloor[3].SetActive(true);
            wallandfloor[1].SetActive(false);
            wallandfloor[2].SetActive(false);
            wallandfloor[0].SetActive(false);
        }
        if (SurvivalEnd.snum == 5)
        {
            wallandfloor[2].SetActive(true);
            wallandfloor[1].SetActive(false);
            wallandfloor[3].SetActive(false);
            wallandfloor[0].SetActive(false);
        }
        if (SurvivalEnd.snum == 6)
        {
            wallandfloor[0].SetActive(true);
            wallandfloor[1].SetActive(false);
            wallandfloor[3].SetActive(false);
            wallandfloor[2].SetActive(false);
        }
        if (SurvivalEnd.snum == 7)
        {
            wallandfloor[1].SetActive(true);
            wallandfloor[1].SetActive(false);
            wallandfloor[2].SetActive(false);
            wallandfloor[0].SetActive(false);
        }
    }

    public void survivalfloor1()
    {
        endgameui.SetActive(true);
    }
}
