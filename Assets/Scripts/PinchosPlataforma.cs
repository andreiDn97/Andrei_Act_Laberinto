using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchosPlataforma : MonoBehaviour
{
    public float velocidad = 3f;
    public float distancia = 3f;
    public Transform zonaRespawn;

    private Vector3 puntoInicial;
    private Vector3 destino;
    private bool movArriba = true;

    void Start()
    {
        puntoInicial = transform.position;

        destino = puntoInicial + Vector3.up * distancia;
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, destino) < 0.1f)
        {
            if (movArriba)
            {
                destino = puntoInicial;
                movArriba = false;
            }

            else
            {
                destino = puntoInicial + Vector3.up * distancia;
                movArriba = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = zonaRespawn.position;
        }
    }
}
