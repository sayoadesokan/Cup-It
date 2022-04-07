using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalEnd : MonoBehaviour
{
    public GameObject[] gameobjects;
    //public Survivalscenecontroller Survcontrol;
    public static int snum;
    public survivalwallfloorcontrol survivalfloor;

    private void Update()
    {
        if (gameobjects[0].active == true)
        {
            snum = 1;
            Debug.Log("Sum = 1");
        }
        if (gameobjects[1].active == true)
        {
            snum = 2;
            ScoreUi.Touchvalue = 5;
            Debug.Log("Sum = 2");
        }
        if (gameobjects[2].active == true)
        {
            snum = 3;
            Debug.Log("Sum = 3");
        }
        if (gameobjects[3].active == true)
        {
            snum = 4;
        }
        if (gameobjects[4].active == true)
        {
            snum = 5;
        }
        if (gameobjects[5].active == true)
        {
            snum = 6;
        }
        if (gameobjects[6].active == true)
        {
            snum = 7;
        }
        if (gameobjects[7].active == true)
        {
            snum = 8;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && snum == 1)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[1].SetActive(true);
            gameobjects[0].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 4;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 2)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[2].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 3;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 3)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[3].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            gameobjects[2].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 5;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 4)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[4].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            gameobjects[2].SetActive(false);
            gameobjects[3].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 4;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 5)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[5].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            gameobjects[2].SetActive(false);
            gameobjects[3].SetActive(false);
            gameobjects[4].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 4;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 6)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[6].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            gameobjects[2].SetActive(false);
            gameobjects[3].SetActive(false);
            gameobjects[4].SetActive(false);
            gameobjects[5].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 4;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 7)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            gameobjects[7].SetActive(true);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(false);
            gameobjects[2].SetActive(false);
            gameobjects[3].SetActive(false);
            gameobjects[4].SetActive(false);
            gameobjects[5].SetActive(false);
            gameobjects[6].SetActive(false);
            Touch1.limit = 0;
            survivalscoreui.Touchvalue = 5;
            TimerS.time += 5;
        }
        if (other.CompareTag("Player") && snum == 8)
        {
            FindObjectOfType<AudioManager>().Play("Enter");
            FindObjectOfType<AudioManager>().Play("Coin");
            Hintandcoin.coinamount += 30;
            Debug.Log("Done");
            survivalfloor.survivalfloor1();
            Time.timeScale = 0;
        }
    }
}
