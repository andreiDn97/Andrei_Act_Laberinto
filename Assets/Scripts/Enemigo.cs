using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject ObjEnemigo;
    public int muertesQuedan;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ObjEnemigo.GetComponent<Muertes>().muertes += muertesQuedan;
        }
    }

}
