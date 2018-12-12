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
    //Funcion para cambiar de nivel mediante una corutina
    public void CambiarNivel()
    {
        pantallaDeCarga.SetActive(true);
        StartCoroutine(CargarEscena());
    }

    IEnumerator CargarEscena()
    {
        AsyncOperation cargaAsincrona = SceneManager.LoadSceneAsync("PruebaInterfaz2");
        while (!cargaAsincrona.isDone)
        {
            barraDeCarga.value = cargaAsincrona.progress;
            yield return null;
        }
    }



    //Funcion para salir del juego
    public void Salir()
    {
        Application.Quit();
    }
}
