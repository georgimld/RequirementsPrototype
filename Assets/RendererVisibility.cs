using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInVersioning = false;

    void Start()
    {
      gameObject.GetComponent<Renderer>().enabled = isVisibleInVersioning;
    }
    void Update()
    {
      if (StateController.Instance.VersioningMode) {
        gameObject.GetComponent<Renderer>().enabled = isVisibleInVersioning;
      }
      else {
        gameObject.GetComponent<Renderer>().enabled = !isVisibleInVersioning;
      }

    }
}
