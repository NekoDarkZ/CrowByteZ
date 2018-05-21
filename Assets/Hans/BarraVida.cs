using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 100;

	public void Damage(float value)
	{
		Health -= value;
		HealthBar.size = Health / 100f;
	}
    public void Recuperar(float value)
    {
        Health = Health + 50;
        HealthBar.size = Health * 100f;
    }

}
