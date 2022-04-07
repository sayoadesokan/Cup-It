using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy15 : MonoBehaviour
{
    public GameObject theeffect;
    public static int limit = 0;
    public GameObject[] TextPrefab;
    private int rand;
    private GameObject disposable;
    public Vector3 offset = new Vector3(0, 2, 1);
    public Vector3 Randominten = new Vector3(-2, 2, 1);
    public GameObject restarttextUI;
    public GameObject touch;
    public GameObject touch0;
    public GameObject obstacle, cup, ball;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && limit <= 4)
        {
            limit++;
            ScoreUi.Touchvalue -= 1;
            Instantiate(theeffect, transform.position, transform.rotation);
            Getrandom();
            FindObjectOfType<AudioManager>().Play("Flame");
            Destroy(gameObject);
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && limit >= 5)
            {
                Touchtostart();
                ScoreUi.Touchvalue = 5;
            }
        }
    }

    public void Getrandom()
    {
        rand = Random.Range(0, TextPrefab.Length);
        disposable = GameObject.FindGameObjectWithTag("Text");
        Destroy(disposable);
        transform.localPosition += offset;
        transform.localPosition += new Vector3(Random.Range(-Randominten.x, Randominten.x), Random.Range(-Randominten.y, Randominten.y), Random.Range(-Randominten.z, Randominten.z));
        Instantiate(TextPrefab[rand], transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Pop");
    }

    void Touchtostart()
    {
        FindObjectOfType<AudioManager>().Play("Fail");
        restarttextUI.SetActive(true);
        obstacle.SetActive(false);
        cup.SetActive(false);
        ball.SetActive(false);
        touch0.SetActive(true);
        touch.SetActive(false);
        Debug.Log("Touch end");
        limit = 0;
    }
}
