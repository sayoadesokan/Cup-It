using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivalscenecontroller : MonoBehaviour
{
    public GameObject Endscene;

    void Update()
    {
        if(TimerS.timeAmt == 0)
        {
            Endscene.SetActive(true);
            Hintandcoin.coinamount += 10;
            FindObjectOfType<AudioManager>().Play("Coin");
        }
    }

    public void survivalflow()
    {

    }
}
