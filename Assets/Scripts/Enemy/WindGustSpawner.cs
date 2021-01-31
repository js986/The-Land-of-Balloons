using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGustSpawner : MonoBehaviour
{
    public static WindGustSpawner instance; 
    // Start is called before the first frame update
    void Start()
    {
        instance = new WindGustSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnGusts(GridManager.GridSquare current)
    {


    }
}
