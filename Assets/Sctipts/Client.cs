using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    bool concliente = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && concliente)
        {
            Debug.Log("Te acercaste al comprador");
            concliente = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Le vendiste marihuana");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && concliente)
        {
            Debug.Log("Te alegaste del comprador");
            concliente = true;
        }
    }
}
