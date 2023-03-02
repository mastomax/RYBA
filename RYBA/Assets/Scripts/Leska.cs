using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leska : MonoBehaviour
{
    public GameObject Leska1;
    
    void Start()
    {
        Vector3 nigga = GetComponent<Transform>().position;
 
        Leska1.transform.position = nigga;
    }

}