using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextVisibility : MonoBehaviour
{
  public GameObject gameObject;
  public bool isVisibleInVersioning = false;

    void Start()
    {
      gameObject.GetComponent<Text>().enabled = isVisibleInVersioning;
    }
    void Update()
    {
      if (StateController.Instance.VersioningMode) {
        gameObject.GetComponent<Text>().enabled = isVisibleInVersioning;
      }
      else {
        gameObject.GetComponent<Text>().enabled = !isVisibleInVersioning;
      }

    }
}
