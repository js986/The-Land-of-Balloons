using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [System.Serializable]
    public struct GridSquare
    {
        public int bottom_bound;
        public int left_bound;
        public int right_bound;
        public int top_bound;
        public GridSquare(int top, int bottom,int left,int right)
        {
            this.bottom_bound = bottom;
            this.left_bound = left;
            this.right_bound = right;
            this.top_bound = top;
        }
    }
    [SerializeField] public List<GridSquare> grid;
    Vector3 position;
    int rand_x;
    int rand_y;
    int rand_num;
    int rand_type;
    public GameObject Red_Gas;
    public GameObject Blue_Gas;
    public GameObject Green_Gas;
    GridSquare current;
    // Start is called before the first frame update
    void Start()
    {
        current = new GridSquare(20, -20, -20, 20);
        SpawnPickups(current);
        grid = new List<GridSquare>();
        grid.Add(current);
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        if(position.x > current.right_bound)
        {
            current = new GridSquare(current.top_bound, current.bottom_bound, current.left_bound+40, current.right_bound + 40);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                SpawnPickups(current);
            }
        }
        if (position.x < current.left_bound)
        {
            current = new GridSquare(current.top_bound, current.bottom_bound, current.left_bound-40, current.right_bound-40);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                SpawnPickups(current);
            }
        }
        if (position.y > current.top_bound)
        {
            current = new GridSquare(current.top_bound+40, current.bottom_bound+40, current.left_bound, current.right_bound);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                SpawnPickups(current);
            }
        }
        if (position.y < current.bottom_bound)
        {
            current = new GridSquare(current.top_bound-40, current.bottom_bound-40, current.left_bound, current.right_bound);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                SpawnPickups(current);
            }
        }

    }

    void SpawnPickups(GridSquare current)
    {
        List<Vector3> pos_arr = new List<Vector3>();
        Vector3 pos;
        rand_num = Random.Range(10, 21);
        for (int i = 0; i < rand_num; i++)
        {
            do
            {
                rand_x = Random.Range(current.left_bound+20, current.right_bound);
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
        
        rand_num = Random.Range(10, 21);
        for (int i = 0; i < rand_num; i++)
        {
            do
            {
                rand_x = Random.Range(current.left_bound, current.right_bound-20);
                rand_y = Random.Range(current.bottom_bound, current.top_bound);
                if (rand_x % 2 != 0)
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
            if (rand_type == 10)
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
            if (rand_type < 6)
            {
                GameObject Gas = Instantiate(Red_Gas);
                Gas.transform.position = new Vector3(rand_x, rand_y, 0);
                continue;
            }
        }

    }

}
