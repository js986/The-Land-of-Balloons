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
      var _newPosition = transform.position;
      _newPosition.y += Mathf.Sin(Time.time * freq) * magnitude * Time.deltaTime;
      transform.position = _newPosition;
    }
}
