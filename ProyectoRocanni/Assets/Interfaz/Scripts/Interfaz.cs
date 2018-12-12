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
    //Metodo para cambiar de nivel mediante una corutina
    public void cambiarNivel()
    {
        pantallaDeCarga.SetActive(true);
        StartCoroutine(cargarEscena());
    }

    IEnumerator cargarEscena()
    {
        AsyncOperation cargaAsincrona = SceneManager.LoadSceneAsync("PruebaInterfaz2");
        while (!cargaAsincrona.isDone)
        {
            barraDeCarga.value = cargaAsincrona.progress;
            yield return null;
        }
    }



    //Metodo para salir del juego
    public void salir()
    {
        Application.Quit();
    }
}
