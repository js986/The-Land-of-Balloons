using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighningBolt : MonoBehaviour
{
    Vector3 player_pos;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        player_pos = PickupManager.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player_pos, speed * Time.deltaTime);
        if (transform.position.Equals(player_pos))
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {

            print("hit player");
            var um = col.GetComponent<UpgradeManager>();
            um.SetDefense(um.defense - 5);
            Destroy(gameObject);
        }
    }
}
