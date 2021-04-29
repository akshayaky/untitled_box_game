using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cameraFollow : MonoBehaviour {	
	
	public Transform platform;
	public Vector3 position;
	public float mouseSensitivity = 100f;

    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.forward * -1 * mouseX);

        Vector3 currentRotation = transform.localRotation.eulerAngles;
        // currentRotation.z = Mathf.Clamp(currentRotation.z, 0, 90);

        if((currentRotation.z >= 0 && currentRotation.z < 90) || currentRotation.z > 270)
        {
        	
        } 
        else if(currentRotation.z <= 270 && currentRotation.z > 200)
        {
        	currentRotation.z = 270f;
        }
        else if(currentRotation.z >= 90)
        {
        	currentRotation.z = 90.0f;
        }
        else if(currentRotation.z == 0)
        {
        	currentRotation.z = 359f;
        }
        // else if(currentRotation.z <= 270)
        // {
        // 	currentRotation.z = 271.0f;	
        // }

        
        transform.localRotation = Quaternion.Euler(currentRotation);
  		// Debug.Log(transform.rotation.z);
     	// float mouseY = Input.GetAxis("Mouse Y");
		// if(mouseY < 0)
		// 	transform.position = new Vector3(0, 3, -10);
		// else if(mouseY > 0)
		// 	transform.position = new Vector3(0, -3, -10);
		// else
		// 	transform.position = new Vector3(0, 0, -10);
    }
}
