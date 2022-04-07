using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scenechange : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    //private int scenesave;

    void Awake()
    {
        //PlayerPrefs.GetInt("levelReached", 1);
        //scenesave = PlayerPrefs.GetInt("scene2");
    }
    void Start1()
    {
        //val = 1;
        //val = PlayerPrefs.GetInt("levelToUnlock1", 1);
        //Debug.Log("Save the scene");
        //val = PlayerPrefs.GetInt("scene2");
        //val2 = PlayerPrefs.GetInt("scene3");
       //val3 = PlayerPrefs.GetInt("scene4");
    }

    void Update()
    {
        if (button0.interactable == true)
        {
            scene1.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
        }
        if (button0.interactable == true && button1.interactable == true)
        {
            //val = 1;
            //Debug.Log("Change scene");
            scene1.SetActive(false);
            scene2.SetActive(true);
            //PlayerPrefs.SetInt("scene2", 1);
            //PlayerPrefs.SetInt("levelReached", GameManager.levelToUnlock);
            //PlayerPrefs.Save();
            //val = PlayerPrefs.GetInt("levelToUnlock1", 1);
        }
        if(button1.interactable == true && button2.interactable == true)
        {
            //Debug.Log("Change scene2");
            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(true);
            //PlayerPrefs.SetInt("scene2", 2);
            //PlayerPrefs.Save();
            //val2 = 2;
            //PlayerPrefs.SetInt("scene3", val2);
        }
        if(button1.interactable == true && button2.interactable == true && button3.interactable == true)
        {
            //Debug.Log("Change scene3");
            scene1.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(true);
            //PlayerPrefs.SetInt("scene2", 3);
            //PlayerPrefs.Save();
            //val3 = 3;
            //layerPrefs.SetInt("scene4", val3);
        }
    }
}
