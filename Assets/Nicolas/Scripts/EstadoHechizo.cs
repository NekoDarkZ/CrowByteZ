using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoHechizo : StateMachineBehaviour {
    private float timerupdate;
    private int random;
    public float timer;
    private Transform posicionjugador;
    public GameObject prefab;
    GameObject prefabClone;
    public float tiempodestruccion;
    private float timerfuego;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);
        timerupdate = timer;
        timerfuego= Time.time + 0.3f;
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
                animator.SetTrigger("pilar");
            }
        }
        else
        {
            timerupdate -= Time.deltaTime;
        }
        if (Time.time > timerfuego)
        {
            posicionjugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            prefabClone = Instantiate(prefab, new Vector2(posicionjugador.position.x, posicionjugador.position.y), Quaternion.identity) as GameObject;
            Destroy(prefabClone, tiempodestruccion);
            timerfuego += 0.60f;
        }
    }
}
