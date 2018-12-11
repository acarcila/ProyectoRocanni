using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
	public Slider slider;
	public GameObject pantallaDeCarga;


    void Start()
    {

    }


    void Update()
    {

    }

  

    //Funcion para salir del juego
    public void Salir()
    {
        Application.Quit();
    }
}
