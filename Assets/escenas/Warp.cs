using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour {
	
	[SerializeField] Object warp;
	[SerializeField] string nivel;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Warp") 
		{
			SceneManager.LoadScene(nivel);
		}
	}
}