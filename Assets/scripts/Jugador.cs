using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    [SerializeField] float velocidad;
    [SerializeField] float salto;
    [SerializeField] int maxsaltos;
    [SerializeField] GC GC;
    [SerializeField] bool muerto = false;
    [SerializeField] BarraVida vida;
    [SerializeField] bool Estar = false;
    private int cantsaltos = 0;
    public float Health = 200;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BloqueBarra")
        {
            Estar = true;
            GC.MostrarBarra();
        }
        ///revisa si toca el piso
        if (collision.gameObject.tag == "Plataforma")
        {
            GetComponent<Animator>().SetBool("Aire", false);
            cantsaltos = 0;
        }
        if (collision.gameObject.tag == "Enemigo")
        {


            if (Health == 200)

                vida.Damage(50);
            Health = Health - 10;

            if (Health == 180)
            {
                vida.Damage(50);
                muerto = true;
                GC.DiegoMuertoEnLaPruebaDeDiseño();
                Destroy(gameObject);

            }
        }
        if (collision.gameObject.tag == "Vida")
        {
            if (Health == 190)
            {
                Health = Health + 10;
                vida.Recuperar(1 / 50);
                Destroy(collision.gameObject);

            }
            if (Health == 200)
            {
                Destroy(collision.gameObject);
            }




        }





        



    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            GetComponent<Animator>().SetBool("Aire", false);
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        ///revisa si dejo de tocar el piso
        if (collision.gameObject.tag == "Plataforma")
        {
            GetComponent<Animator>().SetBool("Aire", true);
        }
    }
    // Use this for initialization
    void Awake()
    {

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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            //salta
            if (maxsaltos >= cantsaltos)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, salto));
                cantsaltos = cantsaltos + 1;
            }

        }
        ////codigo ofensivo////

        //ataque basico
        if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("atacar", false);


        }
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
