using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class ManagerNivel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CargarNivel(string pNombreNivel){
		SceneManager.LoadScene(pNombreNivel);
	}
}
