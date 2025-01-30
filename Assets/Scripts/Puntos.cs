using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public int libros;

    public TextMeshProUGUI textoPuntos;

    private void Update()
    {
        textoPuntos.text = ": " + libros.ToString();
    }
}
