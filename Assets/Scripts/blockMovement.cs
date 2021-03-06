using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    public Transform cam;
    public Rigidbody2D m_Rigidbody; 
    public float m_Thrust = 100f;

    private float x = 0f;
    private float y1 = 0f;


    void FixedUpdate()
    {
        x = m_Thrust *  cam.rotation.z * cam.rotation.w * (1/Mathf.Abs(cam.rotation.w));
        
        if(Mathf.Asin(cam.rotation.w) < 0)
            y1 = m_Thrust *   (Mathf.Sin(cam.rotation.w) - Mathf.Sin(1)) * 10000;   
        
        m_Rigidbody.AddForce(new Vector2(1, 0)  * x);           

    }
}
