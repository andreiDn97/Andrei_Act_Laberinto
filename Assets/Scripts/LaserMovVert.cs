using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovVert : MonoBehaviour
{
    public float velocidad = 3f;
    public float distancia = 5f;
    public Transform zonaRespawn;

    private Vector3 puntoInicial;
    private Vector3 destino;
    private bool movDerecha = true;

    void Start()
    {
        puntoInicial = transform.position;

        destino = puntoInicial + Vector3.right * distancia;
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, destino) < 0.1f)
        {
            if (movDerecha)
            {
                destino = puntoInicial;
                movDerecha = false;
            }

            else
            {
                destino = puntoInicial + Vector3.right * distancia;
                movDerecha = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = zonaRespawn.position;
        }
    }
}
