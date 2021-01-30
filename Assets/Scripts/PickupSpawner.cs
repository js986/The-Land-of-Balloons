using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    float altitude;
    float box_bottom_bound;
    float box_left_bound;
    float box_right_bound;
    float box_top_bound;
    float rand_x;
    float rand_y;
    int rand_num;
    int rand_type;
    public GameObject Red_Gas;
    public GameObject Blue_Gas;
    public GameObject Green_Gas;
    // Start is called before the first frame update
    void Start()
    {
        altitude = 0;
        SpawnPickups(0);
    }

    // Update is called once per frame
    void Update()
    {
        altitude = (int)this.transform.position.y;
    }

    void SpawnPickups(int altitude)
    {
        box_bottom_bound = altitude - 10;
        box_top_bound = altitude + 10;
        box_left_bound = -10;
        box_right_bound = 10;
        rand_num = Random.Range(15, 30);
        for (int i = 0; i < rand_num; i++)
        {
            rand_x = Random.Range(box_left_bound, box_right_bound);
            rand_y = Random.Range(box_bottom_bound, box_top_bound);
            rand_type = Random.Range(1, 10);
            if(rand_type == 10)
            {
                GameObject Gas = Instantiate(Blue_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
            if (rand_type > 6)
            {
                GameObject Gas = Instantiate(Green_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
            if (rand_type <6)
            {
                GameObject Gas = Instantiate(Red_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
        }

    }

}
