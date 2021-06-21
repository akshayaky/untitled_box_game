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
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
