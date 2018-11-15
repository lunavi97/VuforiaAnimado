using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FlashTorch : MonoBehaviour {

    public bool linterna = false;

    private void Start()
    {
        // Desactiva la linterna al comenzar
        CameraDevice.Instance.SetFlashTorchMode(false);
    }

    // Activa o desactiva la linterna
    public void ActivarDesactivarLinterna()
    {
        linterna = !linterna;
        CameraDevice.Instance.SetFlashTorchMode(linterna);
    }
}
