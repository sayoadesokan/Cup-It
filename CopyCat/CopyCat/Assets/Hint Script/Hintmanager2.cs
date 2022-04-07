﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hintmanager2 : MonoBehaviour
{
    public GameObject pointl1;
    public GameObject point2;

    private void Awake()
    {
        pointl1.SetActive(false);
        point2.SetActive(false);
    }
    public void startnow()
    {
        if(Hintandcoin.coinamount >= 100)
        {
            FindObjectOfType<AudioManager>().Play("Coin");
            Debug.Log("Working for 100 coins only");
            Hintandcoin.coinamount -= 100;
            pointl1.SetActive(true);

            StartCoroutine(nextone());
            StartCoroutine(end());
        }
        if (PlayerPrefs.GetInt("Unhint") == 13)
        {
            FindObjectOfType<AudioManager>().Play("Coin");
            Debug.Log("Working for 100 coins only");
            pointl1.SetActive(true);

            StartCoroutine(nextone());
            StartCoroutine(end());
        }
    }

    IEnumerator nextone()
    {
        yield return new WaitForSeconds(2f);

        point2.SetActive(true);
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(6f);

        //pointl1.SetActive(false);
        //point2.SetActive(false);
    }
}

