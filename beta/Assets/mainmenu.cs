using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   
    public void EscenaJuego()
    {
        SceneManager.LoadScene("juego");
    }

     public void opciones()
    {
        SceneManager.LoadScene("opciones");
    }

     public void Salir()
    {
        Application.Quit();
    }
}
