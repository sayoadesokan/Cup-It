using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopcontrollerscript : MonoBehaviour
{
    public Button[] shopbuttons;

    private bool isbuy;
    private bool isbuy1;
    private bool isbuy2;
    private bool isbuy3;
    private bool isbuy4;
    private bool isbuy5;
    private bool isbuy6;
    private bool isbuy7;
    private bool isbuy8;
    private bool isbuy9;
    private bool isbuy10;
    private bool isbuy11;
    private bool isbuy12;
    private bool isbuy13;
    private bool isbuy14;

    void Update()
    {
        isbuy = PlayerPrefs.GetInt("unlock") == 0;
        isbuy1 = PlayerPrefs.GetInt("unlock1") == 0;
        isbuy2 = PlayerPrefs.GetInt("unlock2") == 0;
        isbuy3 = PlayerPrefs.GetInt("unlock3") == 0;
        isbuy4 = PlayerPrefs.GetInt("unlock4") == 0;
        isbuy5 = PlayerPrefs.GetInt("unlock5") == 0;
        isbuy6 = PlayerPrefs.GetInt("unlock6") == 0;
        isbuy7 = PlayerPrefs.GetInt("unlock7") == 0;
        isbuy8 = PlayerPrefs.GetInt("unlock8") == 0;
        isbuy9 = PlayerPrefs.GetInt("unlock9") == 0;
        isbuy10 = PlayerPrefs.GetInt("unlock10") == 0;
        isbuy11 = PlayerPrefs.GetInt("unlock11") == 0;
        isbuy12 = PlayerPrefs.GetInt("unlock12") == 0;
        isbuy13 = PlayerPrefs.GetInt("unlock13") == 0;
        isbuy14 = PlayerPrefs.GetInt("unlock14") == 0;


        if (PlayerPrefs.GetInt("unlock") == 1)
        {
            shopbuttons[0].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock1") == 2)
        {
            shopbuttons[1].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock2") == 3)
        {
            shopbuttons[2].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock3") == 4)
        {
            shopbuttons[3].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock4") == 5)
        {
            shopbuttons[4].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock5") == 6)
        {
            shopbuttons[5].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock6") == 7)
        {
            shopbuttons[6].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock7") == 8)
        {
            shopbuttons[7].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock8") == 9)
        {
            shopbuttons[8].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock9") == 10)
        {
            shopbuttons[9].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock10") == 11)
        {
            shopbuttons[10].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock11") == 12)
        {
            shopbuttons[11].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock12") == 13)
        {
            shopbuttons[12].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock13") == 14)
        {
            shopbuttons[13].interactable = true;
        }

        if (PlayerPrefs.GetInt("unlock14") == 15)
        {
            shopbuttons[14].interactable = true;
        }
    }

    public void jagu()
    {
        if(Hintandcoin.coinamount >= 250)
        {
            Hintandcoin.coinamount -= 250;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[0].interactable = true;
            PlayerPrefs.SetInt("unlock", isbuy ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buycomben()
    {
        if (Hintandcoin.coinamount >= 500)
        {
            Hintandcoin.coinamount -= 500;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[1].interactable = true;
            PlayerPrefs.SetInt("unlock1", isbuy1 ? 2 : 0);
            PlayerPrefs.Save();
        }
    }
    public void buychamp()
    {
        if (Hintandcoin.coinamount >= 500)
        {
            Hintandcoin.coinamount -= 500;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[2].interactable = true;
            PlayerPrefs.SetInt("unlock2", isbuy2 ? 3 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buyskeleton()
    {
        if (Hintandcoin.coinamount >= 1000)
        {
            Hintandcoin.coinamount -= 1000;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[3].interactable = true;
            PlayerPrefs.SetInt("unlock3", isbuy3 ? 4 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buydna()
    {
        if (Hintandcoin.coinamount >= 1000)
        {
            Hintandcoin.coinamount -= 1000;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[4].interactable = true;
            PlayerPrefs.SetInt("unlock4", isbuy4 ? 5 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buyfivesec()
    {
        if (Hintandcoin.coinamount >= 100)
        {
            Hintandcoin.coinamount -= 100;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[5].interactable = true;
            TimerS.time += 5;
            Debug.Log("Add 5 secs");
            PlayerPrefs.SetInt("unlock5", isbuy5 ? 6 : 0);
            PlayerPrefs.Save();
        }
    }
    public void buytensec()
    {
        if (Hintandcoin.coinamount >= 200)
        {
            Hintandcoin.coinamount -= 200;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[6].interactable = true;
            TimerS.time += 10;
            PlayerPrefs.SetInt("unlock6", isbuy6 ? 7 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox1()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[7].interactable = true;
            PlayerPrefs.SetInt("unlock7", isbuy7 ? 8 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox2()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[8].interactable = true;
            PlayerPrefs.SetInt("unlock8", isbuy8 ? 9 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox3()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[9].interactable = true;
            PlayerPrefs.SetInt("unlock9", isbuy9 ? 10 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox4()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[10].interactable = true;
            PlayerPrefs.SetInt("unlock10", isbuy10 ? 11 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox5()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[11].interactable = true;
            PlayerPrefs.SetInt("unlock11", isbuy11 ? 12 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox6()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[12].interactable = true;
            PlayerPrefs.SetInt("unlock12", isbuy12 ? 13 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox7()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[13].interactable = true;
            PlayerPrefs.SetInt("unlock13", isbuy13 ? 14 : 0);
            PlayerPrefs.Save();
        }
    }

    public void buybox8()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            shopbuttons[14].interactable = true;
            PlayerPrefs.SetInt("unlock14", isbuy14 ? 15 : 0);
            PlayerPrefs.Save();
        }
    }

    // Select Button Manager below 
    //Select level coding 

    public void selectjagu()
    {
        PlayerPrefs.SetInt("ballch", 12);
        //ballskincontroller.ballchange += 12;
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void selectcomben()
    {
        PlayerPrefs.SetInt("ballch", 13);
        //ballskincontroller.ballchange += 12;
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void selectchamp()
    {
        PlayerPrefs.SetInt("ballch", 14);
        //ballskincontroller.ballchange += 12;
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void selectskeleton()
    {
        PlayerPrefs.SetInt("ballch", 15);
        //ballskincontroller.ballchange += 12;
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void selectdna()
    {
        PlayerPrefs.SetInt("ballch", 16);
        //ballskincontroller.ballchange += 12;
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    //Boxskin 
    //Box Skin select coding...

    public void skin1()
    {
        PlayerPrefs.SetInt("boxskin", 90);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin2()
    {
        PlayerPrefs.SetInt("boxskin", 91);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin3()
    {
        PlayerPrefs.SetInt("boxskin", 92);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin4()
    {
        PlayerPrefs.SetInt("boxskin", 93);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin5()
    {
        PlayerPrefs.SetInt("boxskin", 94);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin6()
    {
        PlayerPrefs.SetInt("boxskin", 95);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin7()
    {
        PlayerPrefs.SetInt("boxskin", 96);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    public void skin8()
    {
        PlayerPrefs.SetInt("boxskin", 97);
        FindObjectOfType<AudioManager>().Play("Pop");
    }
}
