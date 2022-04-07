using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch1 : MonoBehaviour
{
    public GameObject theeffect;
    public static int limit = 0;
    public static int realminusone;
    public static int real;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && limit <= realminusone)
        {
            limit++;
            survivalscoreui.Touchvalue -= 1;
            Instantiate(theeffect, transform.position, transform.rotation);
            //FindObjectOfType<AudioManager>().Play("Flame");
            Destroy(gameObject);
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && limit >= real)
            {
                survivalscoreui.Touchvalue = real;
                /*if (SurvivalEnd.snum == 2)
                {
                    survivalscoreui.Touchvalue = 5;
                }*/
            }
        }
    }

    private void Update()
    {
        if(SurvivalEnd.snum == 1)
        {
            realminusone = 1;
            real = 2;
            
        }
        if (SurvivalEnd.snum == 2)
        {
            realminusone = 3;
            real = 4;
            
        }
        if (SurvivalEnd.snum == 3)
        {
            realminusone = 2;
            real = 3;
            
        }
        if (SurvivalEnd.snum == 4)
        {
            realminusone = 3;
            real = 4;
            
        }
        if (SurvivalEnd.snum == 5)
        {
            realminusone = 3;
            real = 4;
           
        }
        if (SurvivalEnd.snum == 6)
        {
            realminusone = 3;
            real = 4;
           
        }
        if (SurvivalEnd.snum == 7)
        {
            realminusone = 4;
            real = 5;
            
        }
    }
}
