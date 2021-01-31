using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickupSpawner : MonoBehaviour
{
    public static PickupSpawner instance;
    int rand_x;
    int rand_y;
    int rand_num;
    int rand_type;
    public GameObject Red_Gas;
    public GameObject Blue_Gas;
    public GameObject Green_Gas;
    public int altitude;
    public Text altitude_text;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        altitude = 0;
    }

    // Update is called once per frame
    void Update()
    {
        altitude = (int)this.transform.position.y * 200;
        altitude_text.text = "Altitude: " + altitude.ToString()+ " ft";
    }

    public void SpawnPickups(GridManager.GridSquare current, List<Region> regions)
    {
        List<Vector3> pos_arr = new List<Vector3>();
        Vector3 pos;
        int red_rate = 0;
        int green_rate = 0;
        int blue_rate = 0;
        if (transform.position.y < regions[0].upperExitBound && transform.position.y > regions[0].lowerEntryBound)
        {
            rand_num = Random.Range(15, 26);
            red_rate = 50;
            green_rate = 30;
            blue_rate = 10;
        }
        if (transform.position.y < regions[1].upperExitBound && transform.position.y > regions[1].lowerEntryBound)
        {
            rand_num = Random.Range(15, 26);
            red_rate = 20;
            green_rate = 50;
            blue_rate = 30;
        }
        if (transform.position.y < regions[2].upperExitBound && transform.position.y > regions[2].lowerEntryBound)
        {
            rand_num = Random.Range(15, 21);
            red_rate = 50;
            green_rate = 40;
            blue_rate = 5;
        }
        if (transform.position.y < regions[3].upperExitBound && transform.position.y > regions[3].lowerEntryBound)
        {
            rand_num = Random.Range(10, 15);
            red_rate = 50;
            green_rate = 30;
            blue_rate = 10;
        }
        if (transform.position.y < regions[4].upperExitBound && transform.position.y > regions[4].lowerEntryBound)
        {
            rand_num = Random.Range(5, 10);
            red_rate = 30;
            green_rate = 20;
            blue_rate = 10;
        }
        red_rate = (red_rate / 10) + 1;
        green_rate = (green_rate / 10) + red_rate;
        blue_rate = 10 - (blue_rate / 10) + 1;
        for (int i = 0; i < rand_num; i++)
        {
            do
            {
                rand_x = Random.Range(current.left_bound, current.right_bound);
                rand_y = Random.Range(current.bottom_bound, current.top_bound);
                if(rand_x%2 != 0)
                {
                    rand_x++;
                }
                if (rand_y % 2 != 0)
                {
                    rand_y++;
                }
                pos = new Vector3(rand_x, rand_y, 0);
            } while (pos_arr.Contains(pos));
            pos_arr.Add(pos);
            rand_type = Random.Range(1, 11);
            if(rand_type >= blue_rate)
            {
                GameObject Gas = Instantiate(Blue_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
            if (rand_type < red_rate)
            {
                GameObject Gas = Instantiate(Red_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
            if (rand_type <= green_rate)
            {
                GameObject Gas = Instantiate(Green_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
        }

    }

}
