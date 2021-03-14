using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TextVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInVersioning = false;

    void Start()
    {
      gameObject.GetComponent<TextMeshProUGUI>().enabled = isVisibleInVersioning;
    }
    void Update()
    {
      if (StateController.Instance.VersioningMode) {
        gameObject.GetComponent<TextMeshProUGUI>().enabled = isVisibleInVersioning;
      }
      else {
        gameObject.GetComponent<TextMeshProUGUI>().enabled = !isVisibleInVersioning;
      }

    }
}
