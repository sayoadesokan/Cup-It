using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offmeshsurvival : MonoBehaviour
{
    Renderer oneobj;
    void Awake()
    {
        oneobj = GetComponent<Renderer>();
        StartCoroutine(quickly());
    }

    void Update()
    {
        oneobj.enabled = false;
    }

    IEnumerator quickly()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
}
