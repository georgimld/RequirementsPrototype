using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererScript : MonoBehaviour
{
private LineRenderer lineRenderer;

private float counter;
private float dist;

public GameObject originGameObject;
public GameObject destinationGameObject;
public GameObject canvas;

Transform origin;
Transform destination;

float lineDrawSpeed = 6f;

float startWidth = 1.8f;
float endWidth = 0.1f;


void Start()
{
  origin = originGameObject.transform;
  destination = destinationGameObject.transform;


  lineRenderer = GetComponent<LineRenderer>();
  lineRenderer.SetPosition(0, origin.position);
  lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
  lineRenderer.startWidth = startWidth;
  lineRenderer.endWidth = endWidth;
  dist = Vector3.Distance(origin.position, destination.position);
}

Gradient RenderGradient () {

Color originColor = originGameObject.GetComponent<Renderer>().material.GetColor("_Color");
Color destinationColor = destinationGameObject.GetComponent<Renderer>().material.GetColor("_Color");

float alpha = 1.0f;
Gradient gradient = new Gradient();
gradient.SetKeys(
    new GradientColorKey[] { new GradientColorKey(originColor, 0.0f), new GradientColorKey(destinationColor, 1.0f) },
    new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
);
return gradient;
}


void Update()
{
    renderLine();
    setTextPosition();
}

void renderLine() {
  lineRenderer.colorGradient = RenderGradient();
  if (counter < dist) {
    counter += .1f / lineDrawSpeed;
    float x = Mathf.Lerp(0, dist, counter);
    Vector3 pointA = origin.position;
    Vector3 pointB = getLineEndPoisiton();
    Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
    lineRenderer.SetPosition(1, pointAlongLine);
  }
}

  void setTextPosition () {
     RaycastHit hit;
    if (Physics.Raycast(origin.position,  destination.position - origin.position, out hit)){
      canvas.transform.position = hit.point - (destination.position - origin.position)/2;
      canvas.transform.LookAt(destination.position);
      canvas.transform.Rotate(90, 90, 0, Space.Self);
    }
  }

    Vector3 getLineEndPoisiton () {
    RaycastHit hit;
    if (Physics.Raycast(origin.position,  destination.position - origin.position, out hit)){
      return hit.point;
    }
    else {
      return destination.position;
    }

  }
  

  Vector3 getArrowStartPoisiton () {
    Vector3 arrowStart;
    arrowStart.x = origin.position.x + (destination.position.x - origin.position.x /4);
    arrowStart.y = origin.position.y + (destination.position.y - origin.position.y /4);
    arrowStart.z = origin.position.z + (destination.position.z - origin.position.z /4);
    Debug.Log("arrow starts at: " + arrowStart); 
    return arrowStart;

  }

}


