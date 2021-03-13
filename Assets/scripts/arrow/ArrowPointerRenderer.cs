using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowPointerRenderer : MonoBehaviour
{
private LineRenderer arrowRenderer;

private float counter;
private float dist;

public GameObject originGameObject;
public GameObject destinationGameObject;

private float scale;

Transform origin;
Transform destination;

private Vector3 arrowStartPosition;
private Vector3 arrowEndPosition;


float lineDrawSpeed = 6f;

float startWidth = 6.0f;
float endWidth = 0.1f;


void Start()
{
  origin = originGameObject.transform;
  destination = destinationGameObject.transform;

  scale = destination.localScale.x;

  arrowStartPosition = getArrowStartPoisiton();
  arrowEndPosition = getArrowEndPoisiton();

  arrowRenderer = GetComponent<LineRenderer>();
  arrowRenderer.SetPosition(0, arrowStartPosition);
  arrowRenderer.material = new Material(Shader.Find("Sprites/Default"));
  arrowRenderer.startWidth = startWidth;
  arrowRenderer.endWidth = endWidth;
  dist = Vector3.Distance(arrowStartPosition, arrowEndPosition);

}

Gradient RenderGradient () {

Color color = destinationGameObject.GetComponent<Renderer>().material.GetColor("_Color");

float alpha = 1.0f;
Gradient gradient = new Gradient();
gradient.SetKeys(
    new GradientColorKey[] { new GradientColorKey(color, 0.0f), new GradientColorKey(color, 1.0f) },
    new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
);
return gradient;
}


void Update()
{
    renderArrow();
}

void renderArrow() {
  arrowRenderer.colorGradient =  RenderGradient();

  if (counter < dist) {
    counter += .1f / lineDrawSpeed;
    float x = Mathf.Lerp(0, dist, counter);
    Vector3 pointA = arrowStartPosition;
    Vector3 pointB = arrowEndPosition;
    Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
    arrowRenderer.SetPosition(1, pointAlongLine);
  }
  }

  Vector3 getArrowStartPoisiton () {
     RaycastHit hit;
    if (Physics.Raycast(origin.position,  destination.position - origin.position, out hit)){
      return hit.point - (destination.position - origin.position).normalized*10;
    }
    else {
      return destination.position;
    }

  }

    Vector3 getArrowEndPoisiton () {
    RaycastHit hit;
    if (Physics.Raycast(arrowStartPosition,  destination.position - arrowStartPosition, out hit)){
      return hit.point;
    }
    else {
      return destination.position;
    }

  }
    // Vector3 setText(){

    // }
}


