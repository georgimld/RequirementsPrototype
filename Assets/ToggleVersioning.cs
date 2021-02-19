using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVersioning : MonoBehaviour
{
  void OnMouseDown() {
    StateController.Instance.ToggleVersioningMode();
  }

}
