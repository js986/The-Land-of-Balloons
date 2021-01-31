using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBalloon : MonoBehaviour
{
    public GameObject endScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if (col.CompareTag("Player")){
            endScene.SetActive(true);
            col.GetComponent<PlayerControl>().moveable = false;
            print ("end");
        }

    }
}
