using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hintmanager1 : MonoBehaviour
{
    public GameObject pointl1;

    private void Awake()
    {
        pointl1.SetActive(false);
    }
    public void startnow()
    {
        if(Hintandcoin.coinamount >= 100)
        {
            FindObjectOfType<AudioManager>().Play("Coin");
            Debug.Log("Working for 100 coins only");
            Hintandcoin.coinamount -= 100;
            pointl1.SetActive(true);
            StartCoroutine(end());
        }
        if(PlayerPrefs.GetInt("Unhint") == 13)
        {
            FindObjectOfType<AudioManager>().Play("Coin");
            Debug.Log("Working for 100 coins only");
            pointl1.SetActive(true);
            StartCoroutine(end());
        }
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(4f);

        //pointl1.SetActive(false);
    }
}

