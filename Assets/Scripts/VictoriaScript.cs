using UnityEngine;

public class MostrarVictoria : MonoBehaviour
{
    public GameObject victoriaCanvas; 

    void Start()
    {
        if (victoriaCanvas == null)
        {
            Debug.LogError("El objeto 'victoriaCanvas' no está asignado en el Inspector.");
        }
        else
        {
            victoriaCanvas.SetActive(false); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (victoriaCanvas != null)
            {
                victoriaCanvas.SetActive(true); 
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (victoriaCanvas != null)
            {
                victoriaCanvas.SetActive(false); 
            }
        }
    }
}
