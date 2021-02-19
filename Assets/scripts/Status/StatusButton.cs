using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusButton : MonoBehaviour
{
  public Text ValueText;
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
