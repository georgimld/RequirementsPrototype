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
      Vector3 newPosition = hit.point - (destination.position - origin.position)/2;
      newPosition.y+=2;
      iconGameObject.transform.position = newPosition;

    }
  }
}
