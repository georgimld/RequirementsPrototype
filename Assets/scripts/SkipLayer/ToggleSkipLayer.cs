using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSkipLayer : MonoBehaviour
{
  void Start() {
    gameObject.GetComponent<Button>().onClick.AddListener(StateController.Instance.ToggleSkipLayerMode);
  }

}
