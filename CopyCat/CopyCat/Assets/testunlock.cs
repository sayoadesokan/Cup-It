using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testunlock : MonoBehaviour
{
    public GameObject confirmationui;
    public void unlock()
    {
        PlayerPrefs.SetInt("Unhint", 13);
        PlayerPrefs.Save();
        confirmationui.SetActive(true);
    }
}
