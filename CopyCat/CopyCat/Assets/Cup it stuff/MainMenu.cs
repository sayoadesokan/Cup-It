﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{ 
   public void PlayGame ()
    {
        destroyonclick.limit = 0;
        Destroy2.limit = 0;
        Destroy3.limit = 0;
        Destroy4.limit = 0;
        Destroy5.limit = 0;
        Destroy6.limit = 0;
        Destroy7.limit = 0;
        Destroy8.limit = 0;
        Destroy9.limit = 0;
        Destroy10.limit = 0;
        Destroy11.limit = 0;
        Destroy12.limit = 0;
        Destroy13.limit = 0;
        Destroy15.limit = 0;
        Destroy16.limit = 0;
        Destroy17.limit = 0;
        Destroy18.limit = 0;
        Destroy19.limit = 0;
        Destroy20.limit = 0;
        Destroy21.limit = 0;
        Destroy22.limit = 0;
        Destroy23.limit = 0;
        Destroy24.limit = 0;
        Destroy25.limit = 0;
        Destroy26.limit = 0;
        Destroy27.limit = 0;
        Destroy28.limit = 0;
        Destroy29.limit = 0;
        Destroy30.limit = 0;


        destroyonclick.limit = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
