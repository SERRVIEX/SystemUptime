package com.serrviex.systemuptime;

import android.os.SystemClock;

public class SystemUptime
{
    private static long getElapsedRealtime() 
    {
        return SystemClock.elapsedRealtime() / 1000L;
    }
}