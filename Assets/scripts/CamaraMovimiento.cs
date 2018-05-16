using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovimiento : MonoBehaviour {
    //atributo que instaqncia un gameobject al cual la camara va a seguir
    [SerializeField] GameObject follow ;
    
    void FixedUpdate (){
    float x = follow.transform.position.x;
    float y = follow.transform.position.y;
    transform.position = new Vector3(x, y, transform.position.z);
    }

}



