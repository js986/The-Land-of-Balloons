using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int volume;

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
    private void Update()
    {
            if (this.transform.position.y < PickupSpawner.instance.current.bottom_bound || this.transform.position.y > PickupSpawner.instance.current.top_bound)
            {
                Destroy(this.gameObject);
            }
    }
}
