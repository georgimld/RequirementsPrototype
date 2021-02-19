using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowRenderer : MonoBehaviour
{
private LineRenderer lineRenderer;
private float counter;
private float dist;


public GameObject originGameObject;
public GameObject destinationGameObject;


public Transform origin;
public Transform destination;

public GameObject text;

public float lineDrawSpeed = 6f;

float startWidth = 2.0f;
float endWidth = 0.3f;


void Start()
{


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
  lineRenderer.colorGradient = RenderGradient();

  if (counter < dist) {

    counter += .1f / lineDrawSpeed;

    float x = Mathf.Lerp(0, dist, counter);

    Vector3 pointA = origin.position;
    Vector3 pointB = destination.position;


    Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
    lineRenderer.SetPosition(1, pointAlongLine);
    setTextPosition();
  }

  void setTextPosition () {
    Vector3 middle;
    middle.x = origin.position.x + (destination.position.x - origin.position.x /2);
    middle.y = origin.position.y + (destination.position.y - origin.position.y /2);
    middle.z = origin.position.z + (destination.position.z - origin.position.z /2);
    Debug.Log("middle: " + middle); 
    // text.transform.position = middle;
    text.transform.position = new Vector3(-4.2948f, 0.8641f, -2.7707f);


  }


}

}
