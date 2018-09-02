using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muerte: MonoBehaviour {
    [SerializeField] GameObject protagonist;
    [SerializeField] Camera Barravida;
    [SerializeField] BarraVida vida;
    public float Health =200;
   
    public Vector3 moveDirectionPush;
    public Rigidbody2D EnemyRigidbody;
    public Rigidbody2D ProtaRigidbody;


    // Use this for initialization
    void Start() {
        
       
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "espada")
        {

           
               
            Health = Health - 10;
            moveDirectionPush = EnemyRigidbody.transform.position - col.transform.position;
            EnemyRigidbody.AddForce(moveDirectionPush.normalized *750f);


            if (Health == 180)
            {
                
                Destroy(gameObject);

            }




        }
        if (col.gameObject.tag == "espadaD")
        {

            if (protagonist.GetComponent<SpriteRenderer>().flipX == false)
            {
                
                    
                Health = Health - 10;
                moveDirectionPush = EnemyRigidbody.transform.position - col.transform.position;
                EnemyRigidbody.AddForce(moveDirectionPush.normalized * 750f);

                if (Health == 180)
                {
                    
                    Destroy(gameObject);

                }




            }
        }
        if (col.gameObject.tag == "espadaI")
        {
            if (protagonist.GetComponent<SpriteRenderer>().flipX == true)
            {
                
                    
                Health = Health - 10;
                moveDirectionPush = EnemyRigidbody.transform.position - col.transform.position;
                EnemyRigidbody.AddForce(moveDirectionPush.normalized * 350f);

                if (Health == 180)
                {
                    
                    Destroy(gameObject);

                }





            }
        }
        if (col.gameObject.tag == "Player")
        {


            moveDirectionPush = ProtaRigidbody.transform.position - gameObject.transform.position;
            ProtaRigidbody.AddForce(moveDirectionPush.normalized * 300f);




        }
    }


    public void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "espada")
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

