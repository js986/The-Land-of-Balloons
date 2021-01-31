using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSpawner : MonoBehaviour
{
    public static ThunderSpawner instance;
    public GameObject cloudprefab;
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
        int direction = Random.Range(0, 2);
        float dirX = 0;
        switch (direction)
        {
            case 0:
                dirX = Random.Range(current.left_bound,current.left_bound+3);
                break;
            case 1:
                dirX = Random.Range(current.right_bound-2, current.right_bound);
                break;
        }
        print(dirX);
        Vector3 pos = new Vector3(dirX, current.top_bound - 25, 0);

        Instantiate(cloudprefab, pos, Quaternion.identity) ;
    }

}
