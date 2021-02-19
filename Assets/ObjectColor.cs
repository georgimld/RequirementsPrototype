using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectColor : MonoBehaviour
{

  public GameObject someObject;

  private Renderer objectRenderer;

  public Color normalObjectColor;

  public Color statusObjectColor;

    void Start()
    {
      objectRenderer = someObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (StateController.Instance.StatusMode) {
          objectRenderer.material.SetColor("_Color", statusObjectColor);
        }
        else {
          objectRenderer.material.SetColor("_Color", normalObjectColor);

        }
    }

}
