using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject enemy;
    float randX;
    Vector2 dondeSpawnear;
    public float spawnRate;
    float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        for(int i = 0; i< 10; i++)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(-4.4f, 4.4f);
                dondeSpawnear = new Vector2(randX, transform.position.y);
                Instantiate(enemy, dondeSpawnear, Quaternion.identity);
            }
        }

	}
}
