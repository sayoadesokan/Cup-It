using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ToMenu : MonoBehaviour
{
    public static int currentSceneIndex;
    Scene cindex;

    void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex); 
    }
}
   