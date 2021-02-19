using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkipTextVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInSkipLayer = false;

    void Start()
    {
      gameObject.GetComponent<Text>().enabled = isVisibleInSkipLayer;
    }
    void Update()
    {
      if (StateController.Instance.SkipLayerMode) {
        gameObject.GetComponent<Text>().enabled = isVisibleInSkipLayer;
      }
      else {
        gameObject.GetComponent<Text>().enabled = !isVisibleInSkipLayer;
      }

    }
}
