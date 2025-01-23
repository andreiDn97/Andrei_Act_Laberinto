using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pulsador : MonoBehaviour
{
    public Transform puerta;
    public float anguloRot;
    public float velocidad;
    bool abrir;

    private void Update()
    {
        if(abrir)
        {
            float anguloActual = puerta.rotation.eulerAngles.y;
            float anguloARotar = Mathf.MoveTowardsAngle(anguloActual, anguloRot, Time.deltaTime * velocidad);
            puerta.rotation = Quaternion.Euler(0, anguloARotar, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Player"))
        {
            abrir = true;
        }
    }
}


