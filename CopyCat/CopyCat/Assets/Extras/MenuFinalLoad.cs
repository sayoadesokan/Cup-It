using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinalLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
        StartCoroutine(callad());
    }

    IEnumerator callad()
    {
        yield return new WaitForSeconds(1f);

        Adcontroller.instance.ShowVideoOrInstantiate();
    }
}
