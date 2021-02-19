using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVersioning : MonoBehaviour
{
  void Start() {
    gameObject.GetComponent<Button>().onClick.AddListener(StateController.Instance.ToggleVersioningMode);
  }

}
