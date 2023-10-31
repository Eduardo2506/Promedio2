using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    bool plantante = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && plantante)
        {
            Debug.Log("Entraste al huerto");
            plantante = false;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && !plantante)
        {
            Debug.Log("Plantaste");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !plantante)
        {
            Debug.Log("Saliste del huerto");
            plantante = true;
        }
    }
}
