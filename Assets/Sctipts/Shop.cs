using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    bool entiendita = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player") && entiendita)
        {
            Debug.Log("Entraste a la tienda");
            entiendita = false;
        }
        if (Input.GetKey (KeyCode.Q))
        {
            Debug.Log("Compraste semillas");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !entiendita)
        {
            Debug.Log("Saliste de la tienda");
            entiendita = true;
        }
    }
}
