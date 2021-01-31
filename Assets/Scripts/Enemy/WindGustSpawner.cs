using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGustSpawner : MonoBehaviour
{
    public static WindGustSpawner instance;
    public GameObject windFab;
    public float windSpeed = 5;
    const float cooldown = 1;
    float lastTime = 0;
    public float yRange;
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

        float dirX = 0;
        switch (direction)
        {
            case 0:
                dirX = grid.left_bound;
                break;
            case 1:
                dirX = grid.right_bound;
                break;             
        }

        Vector3 pos = new Vector3(dirX, grid.top_bound - (25 + Random.Range(-yRange, yRange)), 0);

        GameObject wind = Instantiate(windFab);
        wind.GetComponent<WindGust>().speed = windSpeed;
        wind.transform.position = pos;
        if (direction == 0)
        {
            wind.GetComponent<WindGust>().direction = new Vector3(1, 0, 0);
            wind.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            wind.GetComponent<WindGust>().direction = new Vector3(-1, 0, 0);
            wind.GetComponent<SpriteRenderer>().flipX = true;
        }    
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
