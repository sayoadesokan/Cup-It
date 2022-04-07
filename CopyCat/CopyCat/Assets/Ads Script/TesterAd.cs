using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterAd : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(callad());
    }
    IEnumerator callad()
    {
        yield return new WaitForSeconds(3f);

        //AdmobAds.instance.reqBannerAd();
    }
}
