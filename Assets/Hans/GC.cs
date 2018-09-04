using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GC : MonoBehaviour {
    [SerializeField] GameObject gameOverText;
    [SerializeField] bool Estar = false;
    [SerializeField] static GC instance;
    [SerializeField] GameObject Sonido;
    [SerializeField] GameObject SonidoTheme;
    [SerializeField] GameObject CamaraBoss;
    [SerializeField] GameObject CamaraPrincipal;
    [SerializeField] public bool gameOver = false;
    [SerializeField] GameObject BarraVidaJefe;
    [SerializeField] GameObject SonidoMuerte;
    [SerializeField] GameObject BarravidaChao;
    [SerializeField] GameObject Theme;
    [SerializeField] GameObject ThemeBoss;
 



    


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
		if (gameOver == true && Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    public void DiegoMuertoEnLaPruebaDeDiseño()
    {

        BarravidaChao.SetActive(false);
        BarravidaChao = GameObject.FindWithTag("BloqueBarra");
        SonidoMuerte.SetActive(true);
        SonidoMuerte = GameObject.FindWithTag("SonidoMuerte");
        ThemeBoss.SetActive(false);
        ThemeBoss = GameObject.FindWithTag("Sonido");
        Theme.SetActive(false);
        Theme = GameObject.FindWithTag("SonidoTheme");
        gameOverText.SetActive(true);
        gameOverText = GameObject.FindWithTag("texto");

        gameOver = true;

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




        BarraVidaJefe.SetActive(true);
        BarraVidaJefe = GameObject.FindWithTag("BloqueBarra");

        Estar = true;
    }
    

  
}




