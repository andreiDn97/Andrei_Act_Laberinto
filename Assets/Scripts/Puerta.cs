using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Vector3 posicionAbierto;
    public Vector3 posicionCerrada;
    public float velocidad = 3f;

    private bool abrir = false;

    void Start()
    {
        if (posicionCerrada == Vector3.zero)
            posicionCerrada = transform.position;
    }

    void Update()
    {
        if(abrir)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAbierto, velocidad * Time.deltaTime);

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionCerrada, velocidad * Time.deltaTime);

        }
    }

    public void AbrirPuerta()
    {
        abrir = true;
    }

    public void CerrarPuerta()
    {
        abrir = false;
    }

}
