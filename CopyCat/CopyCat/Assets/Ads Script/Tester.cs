using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    //Start is called before the first frame update
   void Start()
   {
        //AdmobAds.instance.requestInterstital();
        StartCoroutine(callad());
   }
    IEnumerator callad()
    {
        yield return new WaitForSeconds(1f);

        Adcontroller.instance.ShowVideoOrInstantiate();
    }
}
