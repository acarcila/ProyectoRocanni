using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    //variables de pantalla de carga
    public Slider barraDeCarga;
    public GameObject pantallaDeCarga;


    void Start()
    {

    }


    void Update()
    {

    }

    IEnumerator CargarEscena()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("pruebaMovimiento");
        while (!asyncLoad.isDone)
        {
            barraDeCarga.value = asyncLoad.progress;
            yield return null;
        }
    }



    //Funcion para salir del juego
    public void Salir()
    {
        Application.Quit();
    }
}
