using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
   public int numeroEscena;

  public void cambiaEscena()
    {
        SceneManager.LoadScene(numeroEscena);
    }
}
