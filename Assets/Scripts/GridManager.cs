using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [System.Serializable]
    public struct GridSquare
    {
        public int bottom_bound;
        public int left_bound;
        public int right_bound;
        public int top_bound;
        public GridSquare(int top, int bottom, int left, int right)
        {
            this.bottom_bound = bottom;
            this.left_bound = left;
            this.right_bound = right;
            this.top_bound = top;
        }
    }
    [SerializeField] public List<GridSquare> grid;
    public GridSquare current;
    public static GridManager instance;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        current = new GridSquare(50, 10, -8, 8);
        grid = new List<GridSquare>();
        grid.Add(current);
        PickupSpawner.instance.SpawnPickups(current);
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        if (position.y > current.top_bound - 20)
        {
            current = new GridSquare(current.top_bound + 40, current.bottom_bound + 40, current.left_bound, current.right_bound);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                PickupSpawner.instance.SpawnPickups(current);
            }
        }
    }
}
