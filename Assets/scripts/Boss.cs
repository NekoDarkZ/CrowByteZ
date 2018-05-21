using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boss : MonoBehaviour
{
    [SerializeField] GameObject protagonist;
    [SerializeField] Camera Barravida;
    [SerializeField] BarraVidaJefe VidaB;

    public float HealthB = 200;

    public Vector3 moveDirectionPush;
  
    public Rigidbody2D ProtaRigidbody;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "espada")
        {


            VidaB.Damage(25);
            HealthB = HealthB - 10;
           
          

            
            if (HealthB == 160)
            {

                Destroy(gameObject);

            }




        }
        if (col.gameObject.tag == "espadaD")
        {

            if (protagonist.GetComponent<SpriteRenderer>().flipX == false)
            {


                VidaB.Damage(25);
                HealthB = HealthB - 10;
                

               

                if (HealthB == 160)
                {

                    Destroy(gameObject);

                }




            }
        }
        if (col.gameObject.tag == "espadaI")
        {
            if (protagonist.GetComponent<SpriteRenderer>().flipX == true)
            {

                VidaB.Damage(25);
                HealthB = HealthB - 10;
      
                if (HealthB == 160)
                {

                    Destroy(gameObject);

                }





            }
        }
        if (col.gameObject.tag == "Player")
        {


            moveDirectionPush = ProtaRigidbody.transform.position - gameObject.transform.position;
            ProtaRigidbody.AddForce(moveDirectionPush.normalized * 3000f);




        }
    }


    public void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "espada")
        {




        }
        if (col.gameObject.tag == "espadaD")
        {

            if (protagonist.GetComponent<SpriteRenderer>().flipX == false)
            {


            }
        }
        if (col.gameObject.tag == "espadaI")
        {
            if (protagonist.GetComponent<SpriteRenderer>().flipX == true)
            {



            }
        }
        if (col.gameObject.tag == "Player")
        {

            {




            }

        }

    }
}



