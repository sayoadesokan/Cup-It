using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialpopup : MonoBehaviour
{
    public GameObject tutpopup;
    public GameObject obstacle;
    public GameObject ball;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject cup;
    public GameObject pause;
    private void Awake()
    {
        StartCoroutine(popup());
    }

    IEnumerator popup()
    {
        yield return new WaitForSeconds(1f);

        tutpopup.SetActive(true);
        pause.SetActive(false);
        obstacle.SetActive(false);
        ball.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        cup.SetActive(false);
    }
}
