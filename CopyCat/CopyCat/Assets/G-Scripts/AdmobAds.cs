/*using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;

public class AdmobAds : MonoBehaviour
{
    string GameID = "ca-app-pub-6679946988672921~7192350303";

    // Sample ads
    string bannerAdId = "ca-app-pub-6679946988672921/7446188095";
    string InterstitialAdID = "ca-app-pub-6679946988672921/7497340746";
    string rewarded_Ad_ID = "ca-app-pub-6679946988672921/6507692705";
    string rewarded_Ad_ID2 = "ca-app-pub-6679946988672921/6507692705";



    public BannerView bannerAd;
    public InterstitialAd interstitial;
    public RewardBasedVideoAd rewardedAd;

    public static AdmobAds instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);

        rewardedAd = RewardBasedVideoAd.Instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(GameID);
    }

    #region rewarded Video Ads

    public void loadRewardVideo()
    {
        rewardedAd.LoadAd(new AdRequest.Builder().Build(), rewarded_Ad_ID);

        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        rewardedAd.OnAdRewarded += HandleUserEarnedReward;
        rewardedAd.OnAdLeavingApplication += HandleOnRewardAdleavingApp;

    }
    
    /// rewarded video events //////////////////////////////////////////////

    public event EventHandler<EventArgs> OnAdLoaded;

    public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

    public event EventHandler<EventArgs> OnAdOpening;

    public event EventHandler<EventArgs> OnAdStarted;

    public event EventHandler<EventArgs> OnAdClosed;

    public event EventHandler<Reward> OnAdRewarded;

    public event EventHandler<EventArgs> OnAdLeavingApplication;

    public event EventHandler<EventArgs> OnAdCompleted;

    /// Rewared events //////////////////////////
   


    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("Video Loaded");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("Video not loaded");
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        Debug.Log("Video Loading");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        Debug.Log("Video Loading failed");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        Debug.Log("Video Loading failed");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        /// reward the player here --------------------
        //GameManager.GMinstance.rewaredPlayer();
        Hintandcoin.coinamount += 10;
    }

    public void HandleOnRewardAdleavingApp(object sender, EventArgs args)
    {
        Debug.Log("when user clicks the video and open a new window");
    }



    public void showVideoAd()
    {
        if(rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
        else
        {
            Debug.Log("Rewarded Video ad not loaded");
        }
    }

    #endregion

    #region rewarded Video Ads2

    public void loadRewardVideo2()
    {
        rewardedAd.LoadAd(new AdRequest.Builder().Build(), rewarded_Ad_ID);

        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded2;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed2;
        rewardedAd.OnAdOpening += HandleRewardedAdOpening2;
        rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad2;
        rewardedAd.OnAdRewarded += HandleUserEarnedReward2;
        rewardedAd.OnAdLeavingApplication += HandleOnRewardAdleavingApp2;

    }

    /// rewarded video events //////////////////////////////////////////////

    public event EventHandler<EventArgs> OnAdLoaded2;

    public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad2;

    public event EventHandler<EventArgs> OnAdOpening2;

    public event EventHandler<EventArgs> OnAdStarted2;

    public event EventHandler<EventArgs> OnAdClosed2;

    public event EventHandler<Reward> OnAdRewarded2;

    public event EventHandler<EventArgs> OnAdLeavingApplication2;

    public event EventHandler<EventArgs> OnAdCompleted2;

    /// Rewared events //////////////////////////



    public void HandleRewardedAdLoaded2(object sender, EventArgs args)
    {
        Debug.Log("Video Loaded");
    }

    public void HandleRewardedAdFailedToLoad2(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("Video not loaded");
    }

    public void HandleRewardedAdOpening2(object sender, EventArgs args)
    {
        Debug.Log("Video Loading");
    }

    public void HandleRewardedAdFailedToShow2(object sender, AdErrorEventArgs args)
    {
        Debug.Log("Video Loading failed");
    }

    public void HandleRewardedAdClosed2(object sender, EventArgs args)
    {
        Debug.Log("Video Loading failed");
    }

    public void HandleUserEarnedReward2(object sender, Reward args)
    {
        /// reward the player here --------------------
        //GameManager.GMinstance.rewaredPlayer();
        Hintandcoin.coinamount += 20;
    }

    public void HandleOnRewardAdleavingApp2(object sender, EventArgs args)
    {
        Debug.Log("when user clicks the video and open a new window");
    }



    public void showVideoAd2()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
        else
        {
            Debug.Log("Rewarded Video ad not loaded");
        }
    }

    #endregion

    #region banner

    public void reqBannerAd()
    {
        this.bannerAd = new BannerView(bannerAdId, AdSize.Banner, AdPosition.Bottom);

        // Called when an ad request has successfully loaded.
        this.bannerAd.OnAdLoaded += this.HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.bannerAd.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;

        AdRequest request = new AdRequest.Builder().Build();

        this.bannerAd.LoadAd(request);

    }


    public void hideBanner()
    {
        this.bannerAd.Hide();
    }
   
    #endregion

    #region interstitial
   
    public void requestInterstital()
    {
        this.interstitial = new InterstitialAd(InterstitialAdID);

        this.interstitial.OnAdLoaded += this.HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        this.interstitial.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        this.interstitial.OnAdClosed += this.HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.interstitial.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;

        AdRequest request = new AdRequest.Builder().Build();

        this.interstitial.LoadAd(request);
    }

    public void ShowInterstitialAd()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

    #endregion

    #region adDelegates

    //Delegates that i dont know
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("Ad Loaded");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("couldnt load ad" + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Debug.Log("Ad Closed");
        requestInterstital(); // Optional : in case you want to load another interstial ad rightaway
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

    #endregion

}*/
