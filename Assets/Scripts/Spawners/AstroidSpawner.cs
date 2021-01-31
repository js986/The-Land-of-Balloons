using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    public static AstroidSpawner instance;

    public float difficulty;

    public GameObject astroid_1;
    public GameObject astroid_2;

    private GameObject player;

    private float rand_x;
    private float rand_y;
    private int type;

    private float radius;

    private float player_radius;

    private void Awake()
    {
        instance = this; 
    }
    private void Start()
    {
        player = this.gameObject;
    }

    public void SpawnAstroid(GridManager.GridSquare grid)
    {
        for (int i = 0; i < 50; i++)
        {
            rand_x = Random.Range(grid.left_bound, grid.right_bound);
            rand_y = Random.Range(grid.top_bound - 15f, grid.top_bound - 10f);
            Vector2 spawnPoint = new Vector2(rand_x, grid.top_bound - 15f);
            type = Random.Range(0, 1);
            GameObject astroid_final = (type == 0) ? astroid_1 : astroid_2;
            radius = astroid_final.GetComponent<CircleCollider2D>().radius;
            player_radius = player.GetComponent<CircleCollider2D>().radius; // So it's possible for the player to get past the astroids
        
            Collider2D EnemyCollision = Physics2D.OverlapCircle(spawnPoint, radius + player_radius);
            if (EnemyCollision == false)
            {
                Instantiate(astroid_final, new Vector3(rand_x, rand_y, 0), Quaternion.identity);
            }
        }
       
    }
}
