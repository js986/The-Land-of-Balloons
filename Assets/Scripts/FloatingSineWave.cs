using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingSineWave : MonoBehaviour
{
    public float freq = 2;
    public float magnitude = .25f;
    private Vector3 _startPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
      transform.position = _startPosition + new Vector3(0.0f, Mathf.Sin(Time.time * freq) * magnitude, 0.0f);
    }
}
