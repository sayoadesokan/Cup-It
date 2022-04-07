using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hintmanager4 : MonoBehaviour
{
    public GameObject pointl1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;

    private void Awake()
    {
        pointl1.SetActive(false);
        point2.SetActive(false);
        point3.SetActive(false);
        point4.SetActive(false);
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
            StartCoroutine(nexttwo());
            StartCoroutine(nextthree());
            StartCoroutine(end());
        }
        if(PlayerPrefs.GetInt("Unhint") == 13)
        {
            FindObjectOfType<AudioManager>().Play("Coin");
            Debug.Log("Working for 100 coins only");
            pointl1.SetActive(true);

            StartCoroutine(nextone());
            StartCoroutine(nexttwo());
            StartCoroutine(nextthree());
            StartCoroutine(end());
        }
    }

    IEnumerator nextone()
    {
        yield return new WaitForSeconds(2f);

        point2.SetActive(true);
    }

    IEnumerator nexttwo()
    {
        yield return new WaitForSeconds(4f);

        point3.SetActive(true);
    }

    IEnumerator nextthree()
    {
        yield return new WaitForSeconds(6f);

        point4.SetActive(true);
    }


    IEnumerator end()
    {
        yield return new WaitForSeconds(10f);

        //pointl1.SetActive(false);
        //point2.SetActive(false);
        //point3.SetActive(false);
        //point4.SetActive(false);
    }
}

