using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public static BirdSpawner instance;
    public float duration;          // Duration of the given cooldown
    float _lastUsed  = 0;           // Last time this cooldown was used
    public float lastUsed{
        get {return _lastUsed;}
    } 

    public GameObject birdPrefab;

    void Awake(){
        instance = this;
    }   

     void Start()
    {
        // StartCoroutine(SpawnBird(prefab,))
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBird(GridManager.GridSquare grid){

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
            // default:
            //     Debug.LogWarning ("oopsie");
            //     break;
        }
        print (dirX);
        Vector3 pos = new Vector3 (dirX, grid.top_bound - 25, 0);

        var burd = Instantiate(birdPrefab, pos, Quaternion.Euler(0,dirRotation, 0));        
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
