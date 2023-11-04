using UnityEngine;

public class Tienda : MonoBehaviour
{
    private bool dentroTienda;
    private Coseca cosecha;
    private Dinero dinero;

    private void Start()
    {
        cosecha = FindObjectOfType<Coseca>();
        dinero = FindObjectOfType<Dinero>();
    }
    private void Update()
    {
        if (dentroTienda && Input.GetKeyDown(KeyCode.V))
        {
            if (cosecha.VenderCosecha(1))
            {
                dinero.GanarDinero(40);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroTienda = true;
            Debug.Log("Entraste a la tienda");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroTienda = false;
            Debug.Log("Saliste de la tienda");
        }
    }
}
