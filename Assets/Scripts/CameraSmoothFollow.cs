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

        float desiredY = target.position.y;
        float smoothedY = Mathf.Lerp(cam.transform.position.y, desiredY, smoothSpeed);

        cam.transform.position = new Vector3(cam.transform.position.x, Mathf.Clamp(smoothedY, 0, 225), 0) + offset;
        

        // Vector3 desiredPos = target.position;
        // Vector3 smoothedPos = Vector3.Lerp(cam.transform.position, desiredPos, smoothSpeed);

        // cam.transform.position = smoothedPos + offset;
    }
}
