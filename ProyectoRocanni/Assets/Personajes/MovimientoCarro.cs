using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarro : MonoBehaviour
{

    public float velocidadMaxima;
	public float velocidadMaximaReversa;

    private float velocidad;
    private enum Marcha { acelerando, frenando, desacelerando };
    private Marcha marcha;

    // Use this for initialization
    void Start()
    {
        velocidad = 0f;
        marcha = Marcha.frenando;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.X))
        {
            if(velocidad > 0)
            {
                marcha = Marcha.frenando;    
            }
            else
            {
                marcha = Marcha.desacelerando;
            }
            
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            if(velocidad < 0)
            {
                marcha = Marcha.frenando;    
            }
            else
            {
                marcha = Marcha.acelerando;
            }
        }
		else
		{
			marcha = Marcha.frenando;
		}

    }

    void FixedUpdate()
    {

        if (marcha == Marcha.acelerando)
        {
            velocidad = Mathf.MoveTowards(velocidad, velocidadMaxima, Time.deltaTime);
        }
		else if(marcha == Marcha.desacelerando)
		{
			velocidad = Mathf.MoveTowards(velocidad, velocidadMaximaReversa, Time.deltaTime*10);   
		}
		else if(marcha == Marcha.frenando)
		{
			velocidad = Mathf.MoveTowards(velocidad, 0f, Time.deltaTime*10);
		}

        this.GetComponent<Rigidbody>().velocity = Vector3.forward * velocidad;
    }
}
