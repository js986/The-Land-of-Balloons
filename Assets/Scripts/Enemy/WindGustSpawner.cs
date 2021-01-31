using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGustSpawner : MonoBehaviour
{
    public static WindGustSpawner instance;
    public GameObject windFab;

    const float cooldown = 5;
    float lastTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        lastTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool isCooldown()
    {
        if (Time.time - lastTime <= cooldown) return true;
        else
        {
            lastTime = Time.time;
            return false;
        }
    }
    //Section starts at y = 275 ends at y = 415
    public void SpawnGusts(GridManager.GridSquare grid)
    {
        int direction = Random.Range(0, 2);

        float dirRotation = 0;
        float dirX = 0;
        switch (direction)
        {
            case 0:
                dirX = grid.left_bound;
                dirRotation = 0;
                break;
            case 1:
                dirX = grid.right_bound;
                dirRotation = 180;
                break;             
        }
        
        Vector3 pos = new Vector3(dirX, grid.top_bound - 25, 0);

        GameObject wind = Instantiate(windFab, pos, Quaternion.Euler(0, dirRotation, 0));
        if (direction == 0) wind.GetComponent<WindGust>().direction = new Vector3(1, 0, 0);
        else wind.GetComponent<WindGust>().direction = new Vector3(-1, 0, 0);
    }
    /*
     * 
     *   else if (transform.position.y > 135 && transform.position.y < 415 && !WindGustSpawner.instance.isCooldown())
        {
            WindGustSpawner.instance.SpawnGusts(current);
        }
     * 
     * 
     * 
     */
}
