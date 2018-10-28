using UnityEngine;
using System.Collections;

public class CodeSample : MonoBehaviour
{
    // Set pattern {delay before start, vibrate time,delay,vibrate,delay,etc}.
    long[] pattern = new long[] {
            0,  // No delay before start.
            60, // Vibrate 60 ms.
        100,// Delay 100 ms.
        60,// Vibrate 60 ms again.
        100,// Delay 100 ms.
        60, // Vibrate 60 ms again.
       200,// Delay 200 ms.
        350, 100, 350, 100, 350,200,60, 100, 60, 100, 60,800 // Create your own pattern .
        };
    
    public void PatternSOS()
    {
        // Just set the vibration pattern and the number of repetitions. Zero is an infinite repetition.
        EasyVibro.Vibrate(pattern, 0);
    }

    public void OrdinaryVibrate3s()
    {
        // Just set the vibration time in milliseconds.
        EasyVibro.Vibrate(3000L);
    }

    public void CancelAllVibrations()
    {
        // Suddenly, all the vibrations stop.
        EasyVibro.Cancel();
    }
}