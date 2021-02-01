using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1;
    public bool spriteFlip = true;
    float direction = 1; // -1 if from right to left vice versa
    public GameObject eggPrefab;
    public float eggDelay = 1f;
    bool canMove = true;

    void Start()
    {
        StartCoroutine(LayEgg(eggDelay));
        
        if (spriteFlip)direction = -1;

        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
            transform.Translate(speed * direction, 0, 0);
    }

    IEnumerator LayEgg(float delay){

        while (true){
            yield return new WaitForSeconds(eggDelay);
            
            Instantiate(eggPrefab, transform.position, Quaternion.identity);
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        
        if (col.collider.CompareTag("Player")){

            canMove = false;
            gameObject.AddComponent<Rigidbody2D>();
            var um = col.collider.GetComponent<UpgradeManager>();
            um.SetDefense(um.defense - 5);
        }
    }
}
