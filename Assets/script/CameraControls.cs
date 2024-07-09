using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public GameObject target;

    public Vector3 posOffset;

    // Start is called before the first frame update
    void Start()
    {
     posOffset = transform.position -target.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = target.transform.position + posOffset;  
    }
}
