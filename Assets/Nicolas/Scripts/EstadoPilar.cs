using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPilar : StateMachineBehaviour {
    private float timerupdate;
    private int random;
    public float timer;
    private Transform posicionjugador;
    public float posiciony;
    public GameObject prefab;
    GameObject prefabClone;
    public float tiempodestruccion;
    private float timerpilar;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);
        timerupdate = timer;
        timerpilar = Time.time + 0.5f;
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if (timerupdate <= 0)
        {
            if (random == 0)
            {
                animator.SetTrigger("movimiento");
            }
            else
            {
                animator.SetTrigger("hechizo");
            }
        }
        else
        {
            timerupdate -= Time.deltaTime;
        }

        if (Time.time > timerpilar)
        {
            posicionjugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            prefabClone = Instantiate(prefab, new Vector2(posicionjugador.position.x, posiciony), Quaternion.identity) as GameObject;
            Destroy(prefabClone, tiempodestruccion);
            //increment next_spawn_time
            timerpilar += 0.45f;
        }



    }
} 