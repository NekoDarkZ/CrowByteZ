using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour {

	[SerializeField] GameObject warp;
	[SerializeField] string nivel;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "creditos") 
		{
			SceneManager.LoadScene(nivel);
		}
	}
}