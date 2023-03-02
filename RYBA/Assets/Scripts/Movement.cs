using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float RotateSpeed;
    void Update()
    {
        float z = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(z, 0, x) * speed * Time.deltaTime;
        transform.Translate(offset);
        float yRotation = Input.GetAxis("Mouse X");
        
        transform.Rotate(0, yRotation * Time.deltaTime * RotateSpeed, 0);
    } 
}
