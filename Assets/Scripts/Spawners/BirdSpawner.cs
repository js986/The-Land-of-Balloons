using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public static BirdSpawner instance;

    public float yRange;
    public float duration;          // Duration of the given cooldown
    float _lastUsed  = 0;           // Last time this cooldown was used
    public float lastUsed{
        get {return _lastUsed;}
    } 

    public GameObject birdPrefab;

    void Awake(){
        instance = this;
    }   

    public void SpawnBird(GridManager.GridSquare grid){

        int direction = Random.Range(0, 2);

        bool spriteDir = false;
        float dirX = 0;
        switch (direction)
        {
            case 0:
                dirX = grid.left_bound;
                spriteDir = false;
                break;
            case 1:
                dirX = grid.right_bound;
                spriteDir = true;      
                break;
        }
        
        Vector3 pos = new Vector3 (dirX, grid.top_bound - ( 25 + Random.Range(-yRange, yRange)), 0);

        var burd = Instantiate(birdPrefab);       
        burd.transform.position = pos;
        burd.GetComponent<SpriteRenderer>().flipX = spriteDir;
        burd.GetComponent<Bird>().spriteFlip = spriteDir;
         
    }

    /// <summary>
    /// Returns whether the cooldown is available for use
    /// </summary>
    /// <returns>True if current time - last used > cooldown duration</returns>
    public bool ValidateCooldown(){

        float _time = Time.time;
        if ( _time - _lastUsed > duration)
        {
            return true;
        }
        return false;

    }

    /// <summary>
    /// Resets cooldown timer if it can be used
    /// </summary>
    /// <returns>True on success</returns>

    public bool UseCooldown(){

        float _time = Time.time;
        
        if (ValidateCooldown()){
            _lastUsed = _time;
            return true;
        }
        return false;
    }
}
