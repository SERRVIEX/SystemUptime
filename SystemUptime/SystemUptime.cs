using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_IOS
using System.Runtime.InteropServices;
#elif UNITY_ANDROID
using UnityEngine;
#endif

public static class SystemUptime
{
    public static long TotalSeconds
    {
        get
        {
#if UNITY_EDITOR
            return Environment.TickCount / 1000;
#elif UNITY_IOS
            return (long)GetSystemUptime();
#elif UNITY_ANDROID
            return GetRealtimeElapsed();
#endif
        }
    }

#if !UNITY_EDITOR && UNITY_ANDROID
    private static AndroidJavaClass _activityClass;
    private static AndroidJavaClass _systemUptimeClass;
    private static AndroidJavaObject _playerActivityContext;
#endif

    // Constructors

#if !UNITY_EDITOR && UNITY_ANDROID
    static SystemUptime()
    {
        _activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        _systemUptimeClass = new AndroidJavaClass("com.serrviex.systemuptime.SystemUptime");
        _playerActivityContext = _activityClass.GetStatic<AndroidJavaObject>("currentActivity");
    }
#endif

    // Methods

#if !UNITY_EDITOR
#if UNITY_IOS || UNITY_STANDALONE_OSX
    [DllImport("__Internal")]
    private static extern float GetSystemUptime();
#elif UNITY_ANDROID
    private static long GetRealtimeElapsed()
    {
        if (_systemUptimeClass != null && _playerActivityContext != null)
            return _systemUptimeClass.CallStatic<long>("getElapsedRealtime");

        return 0;
    }
#endif
#endif
}
