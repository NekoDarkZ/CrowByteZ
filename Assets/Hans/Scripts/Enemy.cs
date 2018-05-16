using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
	private enum states { idle, attack, jump };
	[SerializeField]
	private states currentState;
	// Se asume que la lista tendrá 3 sprites ordenados: Idle, Ataque y Salto...
	// Podríamos reemplazarlo por animaciones para un Animator del gameobject.
	[SerializeField]
	private List<Sprite> sprites = new List<Sprite>();

	private SpriteRenderer mySprite;

	private void Awake()
	{
		currentState = states.idle;
		mySprite = GetComponent<SpriteRenderer>();

		/*LA IDEA ES QUE ESTE ESTADO CAMBIE DEPENDIENDO DE CIERTAS CONDICIONES DADAS
		    EN EL GAMEPLAY, POR EJEMPLO: EL JUGADOR SE ACERCA AL ENEMIGO, O EL ENEMIGO
		    VE AL JUGADOR O CADA CIERTOS SEGUNDOS AUTOMÁTICAMENTE, ETC.*/
		InvokeRepeating("ChangeState", 1f, 5f);
	}

	private void Update()
	{
		switch (currentState)
		{
			case states.idle:
				Debug.Log("Estoy en reposo.");
				break;
			case states.attack:
				Debug.Log("Estoy atacando.");
				break;
			case states.jump:
				Debug.Log("Estoy saltando.");
				break;
			default:
				Debug.Log("Default.");
				break;
		}
	}

	void ChangeState()
	{
		switch (currentState)
		{
			case states.idle:
				currentState = states.attack;
				mySprite.sprite = sprites[1];
				break;
			case states.attack:
				currentState = states.jump;
				mySprite.sprite = sprites[2];
				break;
			case states.jump:
				currentState = states.idle;
				mySprite.sprite = sprites[0];
				break;
			default:
				break;
		}
	}
}
