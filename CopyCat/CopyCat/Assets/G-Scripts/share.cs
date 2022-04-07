using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class share : MonoBehaviour 
{

	public Button shareButton;

	private bool isFocus = false;
	private bool isProcessing = false;

	void Start()
	{
		Debug.Log("I am working");
		shareButton.onClick.AddListener(ShareText);
	}

	void OnApplicationFocus(bool focus)
	{
		isFocus = focus;
	}

	private void ShareText()
	{

#if UNITY_ANDROID
		if (!isProcessing)
		{
			StartCoroutine(ShareTextInAnroid());
		}
#else
		Debug.Log("No sharing set up for this platform.");
#endif
	}



#if UNITY_ANDROID
	public IEnumerator ShareTextInAnroid()
	{
		Debug.Log("I will share");
		var shareSubject = "This the best addictive game out there";
		var shareMessage = "I doubt you can finish the first 10 levels in a week. it is not possible. " +
			"https://play.google.com/store/apps/details?id=com.Streets.Cupit " + " here is the link. C'mon, prove me wrong. ";



		isProcessing = true;

		if (!Application.isEditor)
		{
			//Create intent for action send
			AndroidJavaClass intentClass =
				new AndroidJavaClass("android.content.Intent");
			AndroidJavaObject intentObject =
				new AndroidJavaObject("android.content.Intent");
			intentObject.Call<AndroidJavaObject>
				("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

			//put text and subject extra
			intentObject.Call<AndroidJavaObject>("setType", "text/plain");
			intentObject.Call<AndroidJavaObject>
				("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
			intentObject.Call<AndroidJavaObject>
				("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

			//call createChooser method of activity class
			AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity =
				unity.GetStatic<AndroidJavaObject>("currentActivity");
			AndroidJavaObject chooser =
				intentClass.CallStatic<AndroidJavaObject>
				("createChooser", intentObject, "Share this game with your friends.");
			currentActivity.Call("startActivity", chooser);
		}

		yield return new WaitUntil(() => isFocus);
		isProcessing = false;
	}
#endif
}