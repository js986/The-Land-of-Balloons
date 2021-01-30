using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    //counters for types of gas
    public int green_counter;
    public int blue_counter;
    public int red_counter;
    // Start is called before the first frame update
    void Start()
    {
        green_counter = 0;
        blue_counter = 0;
        red_counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Pickup gas = (Pickup)collision.gameObject.GetComponent(typeof(Pickup));
            switch (collision.gameObject.tag)
            {
                case "Red":
                    red_counter += gas.volume;
                    break;
                case "Green":
                    green_counter += gas.volume;
                    break;
                case "Blue":
                    blue_counter += gas.volume;
                    break;
            }
            Destroy(collision.gameObject);
        }
    }
}
