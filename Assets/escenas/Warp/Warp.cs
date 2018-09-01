using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour {
	
	[SerializeField] GameObject warp;
	[SerializeField] string nivel;
	[SerializeField] GameObject Cargando;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			Cargando.SetActive (true);
			SceneManager.LoadScene(nivel);
		}
	}
}