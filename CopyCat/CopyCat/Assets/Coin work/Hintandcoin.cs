using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class Hintandcoin : MonoBehaviour
{
    public static int coinamount;
    public Text cointext;

    // Start is called before the first frame update
    void Start()
    {
        cointext.GetComponent<Text>();
        coinamount = PlayerPrefs.GetInt("coinamount");
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "C = " + coinamount.ToString();
        PlayerPrefs.SetInt("coinamount", coinamount);
        PlayerPrefs.Save();
    }
}
