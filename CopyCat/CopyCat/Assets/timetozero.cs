using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetozero : MonoBehaviour
{
    public GameObject loseui;

    private void Update()
    {
        if (TimerS.time == 0)
        {
            //loseui.SetActive(true);
        }
    }
}
