using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{

public static StateController Instance {
  get;
  private set;
}
public bool StatusMode = false;
public bool VersioningMode = false;
public bool SkipLayerMode = false;


private void Awake() {
  if (Instance == null) {
      Instance = this;
    DontDestroyOnLoad(gameObject);
  }
  else {
    Destroy(gameObject);
  }
}

public void ToggleStatusMode () {
  StatusMode = !StatusMode;
 }

 public void ToggleVersioningMode () {
   VersioningMode = !VersioningMode;
  }
   public void ToggleSkipLayerMode () {
   SkipLayerMode = !SkipLayerMode;
  }
}
