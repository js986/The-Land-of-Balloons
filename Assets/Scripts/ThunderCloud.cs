using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderCloud : MonoBehaviour
{
    float top_bound;
    float bottom_bound;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        top_bound = this.transform.position.y + 30;
        bottom_bound = this.transform.position.y - 30;
        speed = .10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PickupManager.instance.transform.position.y > this.transform.position.y && this.transform.position.y < top_bound)
        {
            transform.Translate(0, speed, 0);
        }
        if(PickupManager.instance.transform.position.y < this.transform.position.y && this.transform.position.y > bottom_bound) {
            transform.Translate(0, -speed, 0);
        }
    }
}
