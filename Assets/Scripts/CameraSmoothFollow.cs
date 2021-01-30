using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {
        
    }
    void FixedUpdate(){
        Vector3 desiredPos = target.position ;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

        transform.position = smoothedPos + offset;
    }
}
