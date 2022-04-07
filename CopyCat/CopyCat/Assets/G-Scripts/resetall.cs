using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetall : MonoBehaviour
{
    public void Resetall()
    {
        PlayerPrefs.DeleteAll();
    }
}
