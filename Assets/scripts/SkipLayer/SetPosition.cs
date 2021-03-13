using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetPosition : MonoBehaviour
{

    public GameObject iconGameObject;
    public GameObject originGameObject;
    public GameObject destinationGameObject;
    Transform origin;
    Transform destination;
    
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log(iconGameObject.transform.position);
        origin = originGameObject.transform;
        destination = destinationGameObject.transform;
        setTextPosition();
    }


  void setTextPosition () {
     RaycastHit hit;
    if (Physics.Raycast(origin.position,  destination.position - origin.position, out hit)){
      iconGameObject.transform.position = hit.point - (destination.position - origin.position)/2;
          Debug.Log(iconGameObject.transform.position);

    }
  }
}
