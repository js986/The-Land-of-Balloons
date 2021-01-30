using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int volume;
    // Start is called before the first frame update
    void Start()
    {
        switch (this.gameObject.tag)
        {
            case "Red":
                volume = 15;
                break;
            case "Blue":
                volume = 10;
                break;
            case "Green":
                volume = 5;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
