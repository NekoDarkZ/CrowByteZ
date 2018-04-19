using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Preguntar por una tecla para accionar algo cuando es presionada (En este caso la flecha derecha)

		if (Input.GetKeyUp(KeyCode.Z))
		{
			GetComponent<Animator>().SetBool("atacar", false);
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			GetComponent<Animator>().SetBool("atacar", true);
		}
	}
		
	}

