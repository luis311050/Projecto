using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour {

    //the ButtonPauseMenu
    [SerializeField] GameObject paused;

    public void OnPause() // Este método se ejecuta cuando se hace clic en "Pausa"
    {
        Time.timeScale = 0;
        paused.SetActive(true);
       
    }

 public void OnRestart() // Este método se ejecuta cuando se hace clic en "Volver al juego"
    {
            SceneManager.LoadScene("juego");
        ScoreScripts.scoreValue =0;
        Time.timeScale = 1f;
    }

    public void OnResume() // Este método se ejecuta cuando se hace clic en "Volver al juego"
    {
        Time.timeScale = 1f;
        paused.SetActive(false);
    }

    public void OnMenu() // Este método se ejecuta cuando se hace clic en "Reiniciar"
    {
        //Loading Scene0
         SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
         ScoreScripts.scoreValue =0;
    }
}