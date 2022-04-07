using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene().buildIndex == 53)
            {
                Debug.Log("FINISHED GAME!");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Enter");
                FindObjectOfType<AudioManager>().Play("Coin");
                GameManager.CompleteLevel();
                Hintandcoin.coinamount += 10;
            }
        } 
    }
}
