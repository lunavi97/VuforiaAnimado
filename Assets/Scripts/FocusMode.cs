using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FocusMode : MonoBehaviour {

    // Hace foco automáticamente
    public void modoContinuousAuto()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    // Enfoca al infinito, para objetos distantes
    public void modoInfinity()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
    }

    // Enfoca objetos muy pequeños
    public void modoMacro()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_MACRO);
    }

    // Deja el modo de foco como viene por defecto en la cámara del dispositivo
    public void modoNormal()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_NORMAL);
    }

    // Hace foco cuando se toca la pantalla
    public void modoTriggerAuto()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
    }
}
