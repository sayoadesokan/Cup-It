using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class Adcontroller : MonoBehaviour
{
    public GameObject network;
    public static Adcontroller instance; 

    private string storeid = "3708201";

    private string videoid = "video";

    private string bannerad = "BannerFlow";

    private string rewardvid = "Rvideo";

    private string videoid2 = "Rvideo";

    private void Awake()
    {
        if(instance != null)
        {
            //Destroy(gameObject);
        }
        else
        {
            instance = this;
            //DontDestroyOnLoad(gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(storeid, true);
        Monetization.IsReady(videoid);
        Monetization.IsReady(rewardvid);
        Monetization.IsReady(videoid2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Monetization.IsReady(videoid))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(videoid) as ShowAdPlacementContent;

                if(ad != null)
                {
                    ad.Show();
                }
            }
        }
    }

    public void ShowVideoOrInstantiate()
    {
        if (Monetization.IsReady(videoid))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(videoid) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
                StartCoroutine(time());
            }
        }
    }

    public void ShowBannerOrInstantiate()
    {
        if (Monetization.IsReady(bannerad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(bannerad) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
            }
        }
    }

    public void ShowRewardorInstantiate()
    {
        if (Monetization.IsReady(rewardvid))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(rewardvid) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
                StartCoroutine(timereward());
            }
        }
    }

    public void ShowLevelOrInstantiate()
    {
        if (Monetization.IsReady(videoid2))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(videoid2) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
            }
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("10 coins");
        Hintandcoin.coinamount += 10;
        network.SetActive(false);
    }

    IEnumerator timereward()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("20 coins");
        Hintandcoin.coinamount += 20;
        network.SetActive(false);
    }
}
