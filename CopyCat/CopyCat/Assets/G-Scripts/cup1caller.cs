using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup1caller : MonoBehaviour
{
    private bonusanimation bonusanimation;

    void Start()
    {
        bonusanimation = GameObject.FindGameObjectWithTag("cup1").GetComponent<bonusanimation>();
    }

    public void doanimation()
    {
        bonusanimation.canshake();
        Debug.Log("I am working, it is animation");
    }
}
