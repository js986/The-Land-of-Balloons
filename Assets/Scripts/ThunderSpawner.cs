using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSpawner : MonoBehaviour
{
    public static ThunderSpawner instance;
    public GameObject cloudprefab;
    int rand_x;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnCloud(GridManager.GridSquare current)
    {
        rand_x = Random.Range(current.left_bound,current.right_bound-1);
        Vector3 pos = new Vector3(rand_x, current.top_bound - 15, 0);
        Instantiate(cloudprefab, pos, Quaternion.identity);
        rand_x = Random.Range(current.left_bound, current.right_bound - 1);
        pos = new Vector3(rand_x, current.top_bound - 5, 0);
        Instantiate(cloudprefab, pos, Quaternion.identity);
    }

}
