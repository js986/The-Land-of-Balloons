using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1;
    public bool spriteFlip = true;
    float direction = 1; // -1 if from right to left vice versa
    public GameObject eggPrefab;
    float eggDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        eggDelay *= Random.Range(.5f, 1.5f);
        print(eggDelay);
        StartCoroutine(LayEgg(eggDelay));
        
        if (spriteFlip)direction = -1;

        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * direction, 0, 0);
    }

    IEnumerator LayEgg(float delay){

        while (true){
            yield return new WaitForSeconds(eggDelay);
            
            Instantiate(eggPrefab, transform.position, Quaternion.identity);
        }
    }
}
