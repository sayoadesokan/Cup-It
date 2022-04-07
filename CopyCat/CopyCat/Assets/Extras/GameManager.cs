using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    public static int levelToUnlock = 2;
    public int leveltounlockuse;
    public GameObject touchanimUI;
    public GameObject ballconfetti;
    public GameObject ballconfetti1;
    public GameObject ballconfetti2;
    public GameObject ballconfetti3;
    public GameObject ballconfetti4;
    public GameObject ballconfetti5;


    private void Awake()
    {
        /*ballconfetti = GameObject.FindGameObjectWithTag("stan");
        ballconfetti1 = GameObject.FindGameObjectWithTag("stan1");
        ballconfetti2 = GameObject.FindGameObjectWithTag("stan2");
        ballconfetti3 = GameObject.FindGameObjectWithTag("stan3");
        ballconfetti4 = GameObject.FindGameObjectWithTag("stan4");
        ballconfetti5 = GameObject.FindGameObjectWithTag("stan5");*/
        ballconfetti1.SetActive(false);
        ballconfetti2.SetActive(false);
        ballconfetti3.SetActive(false);
        ballconfetti4.SetActive(false);
        ballconfetti5.SetActive(false);
        ballconfetti.SetActive(false);
        /*ballconfetti[0].SetActive(false);
        ballconfetti[0].SetActive(false);
        ballconfetti[0].SetActive(false);
        ballconfetti[1].SetActive(false);
        ballconfetti[2].SetActive(false);
        ballconfetti[3].SetActive(false);
        ballconfetti[4].SetActive(false);
        ballconfetti[5].SetActive(false);*/
        touchanimUI.SetActive(true);
        StartCoroutine(stoptouch());
        levelToUnlock = leveltounlockuse;
    }
    public void CompleteLevel()
    {
        ballconfetti.SetActive(true);
        ballconfetti1.SetActive(true);
        ballconfetti2.SetActive(true);
        ballconfetti3.SetActive(true);
        ballconfetti4.SetActive(true);
        ballconfetti5.SetActive(true);
        /*ballconfetti[1].SetActive(true);
        ballconfetti[2].SetActive(true);
        ballconfetti[3].SetActive(true);
        ballconfetti[4].SetActive(true);
        ballconfetti[5].SetActive(true);*/
        //Instantiate(confetti, transform.position, Quaternion.identity);
        CompleteLevelUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Happy");

        if (levelToUnlock > PlayerPrefs.GetInt("levelReached"))
        {
            Debug.Log("GAME OVER");
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
    }

    IEnumerator stoptouch()
    {
        yield return new WaitForSeconds(2f);

        touchanimUI.SetActive(false);
    }
}
