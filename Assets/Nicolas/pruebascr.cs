using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebascr : MonoBehaviour
{
    private Transform posicionjugador;
    public float posiciony;
    public GameObject prefab;
    GameObject prefabClone;
    public float tiempodestruccion;
    float next_spawn_time;
    // Use this for initialization
    void Start () {
        next_spawn_time = Time.time + 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > next_spawn_time)
        {
            posicionjugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            prefabClone = Instantiate(prefab, new Vector2(posicionjugador.position.x, posiciony), Quaternion.identity) as GameObject;
            Destroy(prefabClone, tiempodestruccion);
            //increment next_spawn_time
            next_spawn_time += 0.5f;
        }


    }
}
