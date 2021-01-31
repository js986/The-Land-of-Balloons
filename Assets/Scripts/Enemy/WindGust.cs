using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGust : MonoBehaviour
{
    //Put WindGust on a seperate physics later from the gas Collectibles

    [SerializeField] Vector3 direction = new Vector3(-1, 0,0);
    [SerializeField] float speed = 1.0f;
    [SerializeField] float attackVal = 5;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += Time.deltaTime * speed * direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ENTERED TRIGGER");
        if(collision.transform.tag == "Player")
        {
            //Subtract def from player
            player.GetComponent<UpgradeManager>().defense -= attackVal;
            Destroy(this.transform.gameObject);
        }
        if(collision.transform.tag != "Player") Destroy(this.transform.gameObject);

    }

    public void SpawnGusts(GridManager.GridSquare current)
    {
        

    }

}
