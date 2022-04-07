using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ratethegame : MonoBehaviour
{
    public GameObject rateui;
    public Button one;
    public Button two;
    public Button three;
    public Button four;
    public Button five;
    public Button six; 

    void Start()
    {
        StartCoroutine(waitsmall());
    }

    void Update()
    {
        
    }

    IEnumerator waitsmall()
    {
        yield return new WaitForSeconds(2f);

        if (one.interactable == true)
        {
            rateui.SetActive(true);
        }
        if (one.interactable == true && two.interactable == true)
        {
            rateui.SetActive(true);
        }
        if (one.interactable == true && two.interactable == true && three.interactable == true)
        {
            rateui.SetActive(true);
        }
        if (one.interactable == true && two.interactable == true && three.interactable == true && four.interactable == true)
        {
            rateui.SetActive(true);
        }
        if (one.interactable == true && two.interactable == true && three.interactable == true && four.interactable == true && five.interactable == true)
        {
            rateui.SetActive(true);
        }
        if(six.interactable == true)
        {
            rateui.SetActive(false);
        }
    }
}
