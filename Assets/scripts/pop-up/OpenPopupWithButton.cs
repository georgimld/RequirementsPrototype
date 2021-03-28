using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class OpenPopupWithButton : MonoBehaviour
{
    public GameObject windowsPopup;
    public GameObject macPopup;

    public Button button;
    OperatingSystem os;
    PlatformID pid;


    void Start()
    {
            Debug.Log("Shot something start!");

        os = Environment.OSVersion;
        pid = os.Platform;
        // windowsPopup.SetActive(false);
        // macPopup.SetActive(false);
        button.GetComponent<Button>().onClick.AddListener(OpenPopup);
                    Debug.Log("pid"+ pid);


    }
    void OpenPopup()
    {
      Debug.Log("Shot something!");
        switch (pid)
        {
            case PlatformID.Unix:
            case PlatformID.MacOSX:
                Debug.Log("Clicked button on mac!");
                macPopup.SetActive(true);
                break;
            default:
                Debug.Log("Clicked button on windows!");
                windowsPopup.SetActive(true);
                break;
        }
    }
}
