using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class comentario : MonoBehaviour
{
    public TextMeshProUGUI messageText; 

    void Start()
    {
        if (messageText == null)
        {
            Debug.LogError("Objeto no asignado");
        }
        else
        {
            messageText.gameObject.SetActive(false); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (messageText != null)
            {
                messageText.gameObject.SetActive(true); 
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (messageText != null)
            {
                messageText.gameObject.SetActive(false); 
            }
        }
    }
}
