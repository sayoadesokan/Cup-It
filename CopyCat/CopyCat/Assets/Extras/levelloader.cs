using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{
    public GameObject loadingscreen;
    public Slider slider;
    public Text progresstext;

    public void Loadlevel (int sceneIndex)
    {
        loadingscreen.SetActive(true);
        StartCoroutine(loadAsynchronously(sceneIndex));
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
        Destroy31.limit = 0;
        Destroy32.limit = 0;
        Destroy33.limit = 0;
        Destroy34.limit = 0;
        Destroy35.limit = 0;
        Destroy36.limit = 0;
        Destroy37.limit = 0;
        Destroy38.limit = 0;
        Destroy39.limit = 0;
        Destroy40.limit = 0;
    }

    IEnumerator loadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            slider.value = progress;
            progresstext.text = progress * 100f + "%";

            yield return null;
        }
    }

    int scenebb;

    public void loadreturn(int currentindex)
    {
        loadingscreen.SetActive(true);
        currentindex = PlayerPrefs.GetInt("SavedScene");

        if (currentindex != 0)
        {
            SceneManager.LoadScene(currentindex);
            StartCoroutine(loadAsynch(currentindex));
        }            
        else
        if (currentindex == 0)
        {
            loadingscreen.SetActive(false);
        }
        else
        return;

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
        Destroy31.limit = 0;
        Destroy32.limit = 0;
        Destroy33.limit = 0;
        Destroy34.limit = 0;
        Destroy35.limit = 0;
        Destroy36.limit = 0;
        Destroy37.limit = 0;
        Destroy38.limit = 0;
        Destroy39.limit = 0;
        Destroy40.limit = 0;
    }

    IEnumerator loadAsynch(int currentindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(currentindex);
        SceneManager.GetSceneByBuildIndex(currentindex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            slider.value = progress;
            progresstext.text = progress * 100f + "%";

            yield return null;
        }
    }
}
