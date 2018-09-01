using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado1 : StateMachineBehaviour {

    private int random;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        random = Random.Range(0, 3);
        //Permite cambiar desde la animacion inicial hacia cualquiera de las 3 de la fase 1 del boss con Triggers//
        if (random == 0)
        {
            animator.SetTrigger("movimiento");
        }
        if (random == 1)
        {
            animator.SetTrigger("hechizo");
        }
        if (random==2)
        {
            animator.SetTrigger("pilar");
        }
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
