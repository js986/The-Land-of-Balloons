using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Collider2D _wallcollider;
    Transform _player;

    void Start()
    {
        _wallcollider = GetComponent<Collider2D>();
        _player = GameObject.FindWithTag("Player").transform;
    }

    void Update(){

        transform.position = new Vector3(transform.position.x, _player.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Player")){
            Physics2D.IgnoreCollision(col.collider, _wallcollider);
        }
    }
}
