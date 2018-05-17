using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
    [SerializeField] GameObject gameOverText;
    [SerializeField] bool gameOver = false;
    [SerializeField] static GameController instance;
	// Use this for initialization
	void Awake () {
		if(instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
    public void DiegoMuertoEnLaPruebaDeDiseño()
    {
        gameOverText.SetActive(true);
        gameOverText = GameObject.FindWithTag("texto");
        
        gameOver = true;
    }
}
