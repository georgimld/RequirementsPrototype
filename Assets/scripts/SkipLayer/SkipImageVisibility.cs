using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipImageVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInSkipLayer = false;

    void Start()
    {
      gameObject.GetComponent<Image>().enabled = isVisibleInSkipLayer;
    }
    void Update()
    {
      if (StateController.Instance.SkipLayerMode) {
        gameObject.GetComponent<Image>().enabled = isVisibleInSkipLayer;
      }
      else {
        gameObject.GetComponent<Image>().enabled = !isVisibleInSkipLayer;
      }

    }

  }
