using UnityEngine;
using System.Collections;

public class FlyCamera : MonoBehaviour {

    /*
    wasd : basic movement
    shift : Makes camera accelerate
    space : Moves camera on X and Z axis only.  So camera doesn't gain any height*/


    public float mainSpeed = 150.0f; //regular speed
    float shiftAdd = 10.5f; //multiplied by how long shift is held.  Basically running
    float maxShift = 100.0f; //Maximum speed when holdin gshift
    float camSens = 0.15f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun= 1.0f;
    public bool rotateOnlyIfMousedown = true;

    void Update () {


      if (Input.GetMouseButtonDown(1))
      		{
      			lastMouse = Input.mousePosition; // $CTK reset when we begin
      		}

      		if (!rotateOnlyIfMousedown ||
      		    (rotateOnlyIfMousedown && Input.GetMouseButton(1)))
      		{
      			lastMouse = Input.mousePosition - lastMouse ;
      			lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0 );
      			lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x , transform.eulerAngles.y + lastMouse.y, 0);
      			transform.eulerAngles = lastMouse;
      			lastMouse =  Input.mousePosition;
      			//Mouse  camera angle done.
      		}


        //Keyboard commands
        Vector3 p = GetBaseInput();

        // Quit on esc
        if (Input.GetKey(KeyCode.Escape)) {
          Application.Quit();
        }

        if (Input.GetKey (KeyCode.LeftShift)){
            totalRun += Time.deltaTime;
            p  = p * totalRun * shiftAdd;
            p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
            p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
            p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
        }
        else{
            totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
            p = p * mainSpeed;

        }

        p = p * Time.deltaTime;
       Vector3 newPosition = transform.position;

       transform.Translate(p);
       if (transform.position.y < 1.0f) {
         print("y "+ transform.position.y);
         Vector3 temp = transform.position;
         transform.position = new Vector3(temp.x, 1.5f, temp.z);
       }


    }

    private Vector3 GetBaseInput() { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey (KeyCode.W)){
            p_Velocity += new Vector3(0, 0 , 1);
        }
        if (Input.GetKey (KeyCode.S)){
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey (KeyCode.A)){
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey (KeyCode.D)){
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }
}
