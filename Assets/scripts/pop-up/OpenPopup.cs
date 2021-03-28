using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class OpenPopup : MonoBehaviour
{
  public GameObject windowsPopup;
  public GameObject macPopup;
   OperatingSystem os;
   PlatformID     pid; 


  void Start(){
    os = Environment.OSVersion;
    pid = os.Platform;
    windowsPopup.SetActive(false);
    macPopup.SetActive(false);

  }
  void OnMouseDown() {
    switch (pid) 
            {
            case PlatformID.Unix:
            case PlatformID.MacOSX:
                macPopup.SetActive(true);
                break;
            default:
                windowsPopup.SetActive(true);
                break;
            }
  }
}
