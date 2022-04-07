using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadrandomscenes : MonoBehaviour
{
    public void Loadrandomnextscene()
    {
        if (Hintandcoin.coinamount >= 50)
        {
            Hintandcoin.coinamount -= 50;
            FindObjectOfType<AudioManager>().Play("Coin");
            SceneManager.LoadScene(53);
            Debug.Log("Scene Loaded");
        }
    }
}
