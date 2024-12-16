using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float giro = 100f; 
    public float velocidad = 25f;  

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");     

        transform.Rotate(0, horizontal * giro * Time.deltaTime, 0);

        Vector3 movement = transform.TransformDirection(Vector3.forward * vertical * velocidad * Time.deltaTime);

        characterController.Move(movement);
    }
}
