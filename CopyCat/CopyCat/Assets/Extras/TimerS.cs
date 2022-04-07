using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerS : MonoBehaviour
{
    Image filling;
    public static int timeAmt = 15;
    public static float time;
    public Text timetext;
    public GameObject loseui;
    public static int numberc;

    void Start()
    {
        numberc = 1;
        filling = this.GetComponent<Image>();
        //FindObjectOfType<AudioManager>().Play("Time");
        time = timeAmt;
        System.DateTime timeamt = System.DateTime.Now;
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            filling.fillAmount = time / timeAmt;
            timetext.text = time.ToString("F0");
        }

        if(time <= 5)
        {
            filling.color = new Color32(255, 0, 0, 255);
        }

        if(time <= 0)
        {
            loseui.SetActive(true);
            Debug.Log("lose screen");
        }
        if (numberc == 1)
        {
            timeAmt = 20;
        }
    }
}
