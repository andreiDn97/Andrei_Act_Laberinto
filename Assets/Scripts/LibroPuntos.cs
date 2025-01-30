using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinroPuntos : MonoBehaviour
{
    public GameObject objPuntos;
    public int librosQuedan;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objPuntos.GetComponent<Puntos>().libros += 1;
            Destroy(gameObject);
        }
    }

}
