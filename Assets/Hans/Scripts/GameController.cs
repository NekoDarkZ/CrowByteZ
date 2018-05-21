using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject Theme;
    [SerializeField] GameObject ThemeBoss;
    [SerializeField] GameObject SonidoMuerte;
    [SerializeField] GameObject BarravidaChao;
    [SerializeField] bool gameOver = false;
    [SerializeField] static GameController instance;



    // Use this for initialization
    void Awake() {
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
    void Update() {
        if (gameOver == true && Input.GetMouseButtonDown(0))
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
}
