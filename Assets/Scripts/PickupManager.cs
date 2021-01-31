using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickupManager : MonoBehaviour
{
    public static PickupManager instance;
    //counters for types of gas
    public int green_counter;
    public int blue_counter;
    public int red_counter;
    public Text green_text;
    public Text blue_text;
    public Text red_text;

    public UpgradeManager _um;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        green_counter = 0;
        blue_counter = 0;
        red_counter = 0;
        _um = this.GetComponent<UpgradeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        green_text.text = green_counter.ToString();
        blue_text.text = blue_counter.ToString();
        red_text.text = red_counter.ToString();

        if(_um.fuel < 0 && red_counter > 0)
        {
            red_counter--;
            _um.SetFuel(_um.fuel + 5);
        }
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
                    //_um.SetFuel(_um.fuel + 5.0f);
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
