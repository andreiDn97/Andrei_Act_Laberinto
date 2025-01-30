using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Muertes : MonoBehaviour
{
    public int muertes;

    public TextMeshProUGUI textoPuntos;

    private void Update()
    {
        textoPuntos.text = ": " + muertes.ToString();
    }
}
