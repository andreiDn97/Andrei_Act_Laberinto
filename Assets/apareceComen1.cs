using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerComentario : MonoBehaviour
{
    public string mensaje; // Escribe el comentario en el Inspector.
    public float duracion = 4f; // Duración del mensaje.
    private bool yaMostrado = false; // Para evitar que el mensaje se repita.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !yaMostrado) // Solo el jugador activa el comentario.
        {
            yaMostrado = true;
            ComentarioManager manager = FindObjectOfType<ComentarioManager>();
            if (manager != null)
            {
                manager.MostrarComentario(mensaje, duracion);
            }
        }
    }
}
