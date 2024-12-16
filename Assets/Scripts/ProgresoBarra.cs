using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgresoBarra : MonoBehaviour
{
    public Slider barraProgreso; 
    public float velocidadProgreso = 0.1f;

    private float progresoActual = 0f; 

    void Start()
    {
        if (barraProgreso != null)
        {
            barraProgreso.value = progresoActual;
        }
    }

    void Update()
    {
        if (barraProgreso != null && progresoActual < barraProgreso.maxValue)
        {
            progresoActual += velocidadProgreso * Time.deltaTime;
            barraProgreso.value = progresoActual;
        }
    }
}
