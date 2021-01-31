using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public float fallSpeed;
    public float deathDelay;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deathDelay);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, -fallSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D col){
        
        if (col.CompareTag("Player")){

            print ("hit player");
            col.GetComponent<UpgradeManager>().defense -= 5;
            Destroy(gameObject);
        }
    }
}
