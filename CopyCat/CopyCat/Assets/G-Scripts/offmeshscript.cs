using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offmeshscript : MonoBehaviour
{
    Renderer oneobj;
    void Awake()
    {
        oneobj = GetComponent<Renderer>();
    }

    void Update()
    {
        oneobj.enabled = false;
    }
}
