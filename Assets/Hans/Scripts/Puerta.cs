using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] GameObject protagonist;
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
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "espadaD")
        {

            if (protagonist.GetComponent<SpriteRenderer>().flipX == false)
            {
                Destroy(gameObject);
            }
        }
        if (col.gameObject.tag == "espadaI")
        {
            if (protagonist.GetComponent<SpriteRenderer>().flipX == true)
            {
                Destroy(gameObject);
            }
        }
        if (col.gameObject.tag == "Player")
        {
            
        }
    }
    public void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "espada")
        {

            Destroy(gameObject);

        }
        if (col.gameObject.tag == "espadaD")
        {

            if (protagonist.GetComponent<SpriteRenderer>().flipX == false)
            {
                Destroy(gameObject);
            }
        }
        if (col.gameObject.tag == "espadaI")
        {
            if (protagonist.GetComponent<SpriteRenderer>().flipX == true)
            {
                Destroy(gameObject);
            }
        }
        if (col.gameObject.tag == "Player")
        {
        
        }
    }
}
