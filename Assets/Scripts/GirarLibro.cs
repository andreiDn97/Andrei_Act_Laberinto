using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarLibro : MonoBehaviour
{
    [SerializeField] private float velocidadRotacion = 100f; 
    private Vector3 direccionRotacion = new Vector3(0, 1, 0); 

    private void Update()
    {
        transform.Rotate(direccionRotacion * velocidadRotacion * Time.deltaTime);
    }
}
