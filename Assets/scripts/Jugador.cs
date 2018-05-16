using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
    
    [SerializeField] float velocidad;
    [SerializeField] float salto;
    [SerializeField] GameController GC;
    [SerializeField] bool muerto = false;



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bloque")
        {

            muerto = true;
            GC.DiegoMuertoEnLaPruebaDeDiseño();
        }
    }
    // Use this for initialization
    void Awake () {
		
	}


    // Update is called once per frame
    void Update()
    {

        ////Codigo de movimiento////
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //flipea la  imagen a la derecha si esta hacia la izquierda
            if (GetComponent<SpriteRenderer>().flipX == true)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            //mueve el personaje a la derechachacha
            GetComponent<Animator>().SetBool("caminar", true);
            transform.Translate(velocidad, 0, 0);

        }
        //Preguntar por una tecla para accionar algo cuando es presionada (En este caso la flecha izquierda)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //flipea la  imagen a la izquierda si esta hacia la derecha
            if (GetComponent<SpriteRenderer>().flipX == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            //mueve el personaje a la izquierdadada
            GetComponent<Animator>().SetBool("caminar", true);
            transform.Translate(-velocidad, 0, 0);

        }
        //esto es para eliminar el movimiento
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("caminar", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetBool("caminar", false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //mueve el personaje a la izquierdadada

            GetComponent<Animator>().SetBool("saltar", true);
            transform.Translate(0, salto, 0);

        }
        if (!Input.GetKey(KeyCode.UpArrow))
        {

            //mueve el personaje a la izquierdadada

            GetComponent<Animator>().SetBool("saltar", false);
            transform.Translate(0, 0, 0);

        }
        ////codigo ofensivo////

        //ataque basico
        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("atacar", false);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("atacar", true);
        }

        //ataque especial
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("especial", false);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("especial", true);
        }

        ////codigo especial////





}
   }
