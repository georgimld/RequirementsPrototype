using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClosePopup : MonoBehaviour
{
  public Button button;
  public GameObject popup;

  void Start () {
		button = button.GetComponent<Button>();
		button.onClick.AddListener(OnClick);
	}
  void OnClick(){
  popup.SetActive(false);
}
}
