using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class platformControll : MonoBehaviour
{
    public float mouseSensitivity = 10f;
   	public Transform platform;

	public Rigidbody2D m_Rigidbody; 

	public float m_Thrust = 10000f;
   	float xRotation;

    void Start()
    {
        
    }

    void FixedUpdate()
    {	
    	
        // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        // float mouseY = Input.GetAxis("Mouse Y"); //* mouseSensitivity * Time.deltaTime;
  //       // Debug.Log(mouseY.ToString());
		// // xRotation -= mouseY;    
  //       // xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // m_Rigidbody.AddForce(new Vector2(0, 1) * m_Thrust * mouseY * -1 );

  //       // transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // platform.Rotate(Vector3.forward * mouseX);
    }
}
