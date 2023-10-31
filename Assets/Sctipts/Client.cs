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
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && !concliente)
        {
            Debug.Log("Le vendiste marihuana");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !concliente)
        {
            Debug.Log("Te alejaste del comprador");
            concliente = true;
        }
    }
}
