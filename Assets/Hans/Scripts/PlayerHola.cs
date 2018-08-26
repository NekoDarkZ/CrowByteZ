using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHola : MonoBehaviour {
    // Variable para gestionar la velocidad desde Unity
    public float speed;

    // Variable para establecer un punto de destino
    Vector3 target;

    void Start()
    {
        // Inicialmente el punto de destino es la posición actual
        target = transform.position;
    }

    void Update()
    {

        // Detectamos cuando hacemos clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            // Buscamos la posición del clic respecto a la escena
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Establecemos la z a 0 para que no se modifique la profundidad
            target.z = 0f;
        }

        // Movemos el objeto hacia el punto de destino a una velocidad rectificada
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Optaticamente podemos debugear una línea con el trayecto a recorrer
        Debug.DrawLine(transform.position, target, Color.green);
    }
}

