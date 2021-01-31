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
        altitude = (int)this.transform.position.y * 10;
        altitude_text.text = "Altitude: " + altitude.ToString()+ " ft";
    }

    public void SpawnPickups(GridManager.GridSquare current)
    {
        List<Vector3> pos_arr = new List<Vector3>();
        Vector3 pos;
        rand_num = Random.Range(25, 36);
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
