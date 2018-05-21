using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaJefe : MonoBehaviour {


    public Scrollbar HealthBarB;
    public float HealthB = 100;

    public void Damage(float value)
    {
        HealthB -= value;
        HealthBarB.size = HealthB /100f;
    }
    public void Recuperar(float value)
    {
        HealthB = HealthB + 50;
        HealthBarB.size = HealthB * 100f;
    }

}