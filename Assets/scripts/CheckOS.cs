using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class CheckOS : MonoBehaviour
{
    public GameObject popup;
    public bool isVisibleMac;

    // Start is called before the first frame update
    void Start()
    {
        OperatingSystem os = Environment.OSVersion;
        PlatformID     pid = os.Platform;
        popup.SetActive(false);

   
        switch (pid) 
            {
            case PlatformID.Win32NT:
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.WinCE:
                Debug.Log("I'm on windows!");
                popup.SetActive(!isVisibleMac);
                break;
            case PlatformID.Unix:
                Debug.Log("I'm a linux box!");
                popup.SetActive(isVisibleMac);
                break;
            case PlatformID.MacOSX:
                Debug.Log("I'm a mac!");
                popup.SetActive(isVisibleMac);
                break;
            default:
                Debug.Log("No Idea what I'm on!");
                break;
            }
    }
}
