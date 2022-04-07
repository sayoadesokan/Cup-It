using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class survivalscoreui : MonoBehaviour
{
    public static int Touchvalue;
    public int Touchconnect;
    public Text Touchtext;

    private void Awake()
    {
        Touchvalue = Touchconnect;
    }
    // Start is called before the first frame update
    void Start()
    {
        Touchtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Touchtext.text = "T/A: " + Touchvalue;

        if (SurvivalEnd.snum == 2)
        {
            //Touchvalue = 5;
        }
    }

   
}
