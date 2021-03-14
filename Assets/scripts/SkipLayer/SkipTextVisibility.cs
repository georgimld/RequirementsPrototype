using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class SkipTextVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInSkipLayer = false;

    void Start()
    {
      gameObject.GetComponent<TextMeshProUGUI>().enabled = isVisibleInSkipLayer;
    }
    void Update()
    {
      if (StateController.Instance.SkipLayerMode) {
        gameObject.GetComponent<TextMeshProUGUI>().enabled = isVisibleInSkipLayer;
      }
      else {
        gameObject.GetComponent<TextMeshProUGUI>().enabled = !isVisibleInSkipLayer;
      }

    }
}
