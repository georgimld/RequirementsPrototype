using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShowStatusButton : MonoBehaviour
{

public Button startButton;
public Button statusButton;

  void Start () {
		startButton = startButton.GetComponent<Button>();
		startButton.onClick.AddListener(OnClick);
    statusButton.gameObject.SetActive (false);

	}
  void OnClick(){
      statusButton.gameObject.SetActive (true);
}
}
