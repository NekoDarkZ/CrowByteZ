using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player54 : MonoBehaviour {
    [SerializeField] GameController GC;
    [SerializeField] bool muerto = false;
	
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bloque")
        {

            muerto = true;
            GC.DiegoMuertoEnLaPruebaDeDiseño();
        }
    }
}
