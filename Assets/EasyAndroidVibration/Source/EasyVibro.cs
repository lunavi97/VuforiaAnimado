using UnityEngine;

public static class EasyVibro
{
#if UNITY_ANDROID
    static AndroidJavaObject vibrator = null;
#endif
    static EasyVibro()
    {
#if UNITY_ANDROID
        AndroidJavaClass _class = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityPlayerActivity = _class.GetStatic<AndroidJavaObject>("currentActivity");
        vibrator = unityPlayerActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#endif
    }

    public static bool HasVibrator()
    {
#if UNITY_ANDROID
        return vibrator.Call<bool>("hasVibrator");
#else
        return false;
#endif
    }

    public static void Cancel()
    {
#if UNITY_ANDROID
        if (HasVibrator()) vibrator.Call("cancel");
#endif
    }

    public static void Vibrate(long[] pattern, int repeate = -1)
    {
#if UNITY_ANDROID
        if (HasVibrator()) vibrator.Call("vibrate", pattern, repeate);
#endif
    }

    public static void Vibrate(long time)
    {
#if UNITY_ANDROID
        if (HasVibrator()) vibrator.Call("vibrate", time);
#endif
    }

}