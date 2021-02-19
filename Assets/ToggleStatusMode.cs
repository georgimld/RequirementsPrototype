using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStatusMode : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
      gameObject.GetComponent<Button>().onClick.AddListener(StateController.Instance.ToggleStatusMode);
    }
}
