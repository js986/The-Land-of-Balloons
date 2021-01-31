using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    Transform target;
    Camera cam;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {
        cam = Camera.main;
        target = transform;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    }
    void FixedUpdate(){
        
        Vector3 desiredPos = target.position;
        Vector3 smoothedPos = Vector3.Lerp(cam.transform.position, desiredPos, smoothSpeed);

        cam.transform.position = smoothedPos + offset;
    }
}
