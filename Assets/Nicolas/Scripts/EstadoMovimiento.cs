using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoMovimiento : StateMachineBehaviour {
    private float timerupdate;
    public float speed;
    private int random;
    public float timer;
    private Transform posicionjugador;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 2);
        posicionjugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        timerupdate = timer;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (timerupdate <= 0)
        {

            if (random==0)
            {
                animator.SetTrigger("pilar");
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

        Vector2 target = new Vector2(posicionjugador.position.x, animator.transform.position.y);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, target, speed * Time.deltaTime);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

    }
}