using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    public int counter;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        this.transform.position = new Vector3(this.transform.position.x + x*4*Time.deltaTime, this.transform.position.y, this.transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
        if (collision.gameObject.layer == 3)
        {
            counter++;
            Destroy(collision.gameObject);
        }
    }
}
