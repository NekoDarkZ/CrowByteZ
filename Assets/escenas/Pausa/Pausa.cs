using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

	public static bool JuegoEnPausa = false;

	public GameObject MenuPausaUI;

	[SerializeField] GC GC;

	// Update is called once per frame
	void Update () {
		if (GC.gameOver == false) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				if (JuegoEnPausa) {
					Reanudar ();
				} else {
					Pausar ();
				}
			}	
		}
	}

	public void Reanudar(){
		MenuPausaUI.SetActive (false);
		Time.timeScale = 1f;
		JuegoEnPausa = false;
	}

	void Pausar(){
		MenuPausaUI.SetActive (true);
		Time.timeScale = 0f;
		JuegoEnPausa = true;
	}
}
