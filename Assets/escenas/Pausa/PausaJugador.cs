using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaJugador : MonoBehaviour {

	public Rigidbody2D rb;

	public Pausa ps;

	// Update is called once per frame
	void Update () {
		if  (Pausa.JuegoEnPausa == true) {
			rb.freezeRotation = true;
		} else {
			rb.freezeRotation = false;
		}
	}
}
