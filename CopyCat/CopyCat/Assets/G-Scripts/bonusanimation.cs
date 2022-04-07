using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonusanimation : MonoBehaviour
{
    public Animator bonus1;
    public Animator bonus2;
    public Animator bonus3;

    private void Start()
    {
        bonus1 = GetComponent<Animator>();
    }

    public void canshake()
    {
        bonus1.SetTrigger("on1");
    }

}
