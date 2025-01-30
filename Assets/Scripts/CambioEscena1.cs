using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena1 : MonoBehaviour
{
    public int numeroEscena;

    public void cambiarEscena()
    {
        SceneManager.LoadScene(numeroEscena);
    }

    
}
