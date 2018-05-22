using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
	private enum states { Derecha, Izquierda,};
	[SerializeField]
	private states currentState;
    [SerializeField] float velocidad;
    private void Awake()
	{
		currentState = states.Derecha;
		//Llama cada 5 segundos al subprograma ChangeState infinitamente. 
		//El subprograma se ejecuta durante 1 segundo por cada llamada.
		InvokeRepeating("ChangeState", 1f, 1f);
	}

	private void Update()
	{
		switch (currentState)
		{
			case states.Derecha:
                transform.Translate(velocidad, 0, 0);

                break;
			case states.Izquierda:
                transform.Translate(-velocidad, 0, 0);
                break;
			default:
				break;
		}
	}

	void ChangeState()
	{
		switch (currentState)
		{
			case states.Izquierda:
				currentState = states.Derecha;
				break;
			case states.Derecha:
				currentState = states.Izquierda;
				break;
			default:
				break;
		}
	}
}
