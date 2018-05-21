using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GcBoss : MonoBehaviour {
    [SerializeField] GameObject gameOverText;
    [SerializeField] bool Estar = false;
    [SerializeField] static GcBoss instance;
    [SerializeField] GameObject Sonido;
    [SerializeField] GameObject SonidoTheme;
    [SerializeField] GameObject CamaraBoss;
    [SerializeField] GameObject CamaraPrincipal;



    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void MostrarBarra()
    {

        CamaraPrincipal.SetActive(false);
        CamaraPrincipal = GameObject.FindWithTag("MainCamera");
        CamaraBoss.SetActive(true);
        CamaraBoss = GameObject.FindWithTag("CamaraBoss");


        SonidoTheme.SetActive(false);
        SonidoTheme = GameObject.FindWithTag("SonidoTheme");
        
        Sonido.SetActive(true);
        Sonido = GameObject.FindWithTag("Sonido");
        gameOverText.SetActive(true);
        gameOverText = GameObject.FindWithTag("BloqueBarra");

        Estar = true;


    }
}

