using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleAndroidNotifications;
using System;

public class NotificationMove : MonoBehaviour
{
    private bool ispause = true; 

    private string title = "CUP IT!";

    private string content = "Hope we did not scare you off, come cup it!";

    private string title1 = "CUP IT!";

    private string content1 ="It's been a while, If you lost check the shop for FREE coins so you can use the hint";

    void OnApplicationPause(bool pause)
    {
#if UNITY_ANDROID

        NotificationManager.CancelAll();
        if (pause)
        {
            DateTime timeTonotify = DateTime.Now.AddHours(5);
            TimeSpan time = new TimeSpan();
            NotificationManager.SendWithAppIcon(time, title, content, Color.green, NotificationIcon.Clock);
        }
#endif
    }

    private void OnApplicationQuit()
    {
        {
#if UNITY_ANDROID
            DateTime timeTonotify = DateTime.Now.AddMinutes(600);
            TimeSpan time = new TimeSpan();
            NotificationManager.SendWithAppIcon(time, title1, content1, Color.green, NotificationIcon.Clock);
#endif
        }
    }

    public void Starttosend()
    {
#if UNITY_ANDROID
        DateTime timeTonotify = DateTime.Now.AddMinutes(180);
        TimeSpan time = new TimeSpan();
        NotificationManager.SendWithAppIcon(time, title, content, Color.green, NotificationIcon.Clock);
#endif
    }
}
