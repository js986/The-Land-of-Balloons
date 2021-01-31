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
    [SerializeField]public List<Region> regions;
    public GridSquare current;
    public static GridManager instance;
    Vector3 position;
    public GameObject Rain;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        current = new GridSquare(10, 0, -18, 19);
        grid = new List<GridSquare>();
        grid.Add(current);
        PickupSpawner.instance.SpawnPickups(current, regions);
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;

        if (position.y > current.top_bound - 15)
        {
            current = new GridSquare(current.top_bound + 10, current.bottom_bound + 10, current.left_bound, current.right_bound);
            if (!grid.Contains(current))
            {
                grid.Add(current);
                PickupSpawner.instance.SpawnPickups(current,regions);
                if (current.top_bound < regions[4].upperExitBound && current.bottom_bound > regions[3].lowerEntryBound + 25)
                {
                    AstroidSpawner.instance.SpawnAstroid(current);
                }

                if (current.top_bound < regions[1].upperExitBound && current.bottom_bound > regions[1].lowerEntryBound)
                {
                    ThunderSpawner.instance.SpawnCloud(current);
                }
            }
        }

        // Spawn enemies based on region, region list editable in inspector
        if ((current.top_bound < regions[0].upperExitBound && current.bottom_bound > regions[0].lowerEntryBound) && 
            BirdSpawner.instance.UseCooldown())
        {
            BirdSpawner.instance.SpawnBird(current);
        }
        else if(current.top_bound < regions[2].upperExitBound && current.bottom_bound > regions[2].lowerEntryBound && 
            !WindGustSpawner.instance.isCooldown())
        {
            WindGustSpawner.instance.SpawnGusts(current);
        }
        if (current.top_bound < regions[1].upperExitBound && current.bottom_bound > regions[1].lowerEntryBound)
        {
            Rain.SetActive(true);
        }
        else
        {
            Rain.SetActive(false);
        }
    }

    void OnDrawGizmos(){

        // Gizmos.DrawCube( new Vector3 ( current.left_bound + 9, current.top_bound - 20, 0 ), new Vector3(18, 40, 0));
    }
}
