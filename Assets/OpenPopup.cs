using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopup : MonoBehaviour
{
  public GameObject popup;

  void Start(){
    popup.SetActive(false);
  }
  void OnMouseDown() {
    popup.SetActive(true);
  }
}
