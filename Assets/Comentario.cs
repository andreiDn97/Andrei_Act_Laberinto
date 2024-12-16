using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class ComentarioManager : MonoBehaviour
{
    public TextMeshProUGUI comentarioTexto; // Arrastra el TextMeshPro aquí en el Inspector.

    void Start()
    {
        comentarioTexto.text = ""; // Comienza vacío.
    }

    public void MostrarComentario(string mensaje, float duracion)
    {
        StartCoroutine(MostrarTexto(mensaje, duracion));
    }

    private IEnumerator MostrarTexto(string mensaje, float duracion)
    {
        comentarioTexto.text = mensaje; // Muestra el mensaje.
        yield return new WaitForSeconds(duracion); // Espera el tiempo definido.
        comentarioTexto.text = ""; // Borra el mensaje.
    }
}

