using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StatusButton : MonoBehaviour
{
  public TextMeshProUGUI ValueText;

    void Start () {

        ValueText = GetComponent<TextMeshProUGUI> ();
    }
    void Update()
    {
      if (StateController.Instance.StatusMode) {
        ValueText.text = "Status mode: on";
      }
      else {
        ValueText.text = "Status mode: off";
      }
    }
}
