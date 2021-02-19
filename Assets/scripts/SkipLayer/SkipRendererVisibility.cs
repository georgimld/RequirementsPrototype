using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipRendererVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInSkipLayer = false;

    void Start()
    {
      gameObject.GetComponent<Renderer>().enabled = isVisibleInSkipLayer;
    }
    void Update()
    {
      if (StateController.Instance.SkipLayerMode) {
        gameObject.GetComponent<Renderer>().enabled = isVisibleInSkipLayer;
      }
      else {
        gameObject.GetComponent<Renderer>().enabled = !isVisibleInSkipLayer;
      }

    }
}
