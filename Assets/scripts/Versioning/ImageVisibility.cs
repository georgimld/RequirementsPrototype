using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInVersioning = false;

    void Start()
    {
      gameObject.GetComponent<Image>().enabled = isVisibleInVersioning;
    }
    void Update()
    {
      if (StateController.Instance.VersioningMode) {
        gameObject.GetComponent<Image>().enabled = isVisibleInVersioning;
      }
      else {
        gameObject.GetComponent<Image>().enabled = !isVisibleInVersioning;
      }

    }

  }
