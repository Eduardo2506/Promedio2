using UnityEngine;

public class Granja : MonoBehaviour
{
    private bool dentroGranja = false;
    private Semillas semillas;
    private Dinero dinero;

    private void Start()
    {
        semillas = FindObjectOfType<Semillas>();
        dinero = FindObjectOfType<Dinero>();
    }
    private void Update()
    {
        if (dentroGranja && Input.GetKeyDown(KeyCode.C))
        {
            semillas.ObtenerSemillas(1);
            dinero.GastarDinero(10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroGranja = true;
            Debug.Log("Entraste a la granja");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroGranja = false;
            Debug.Log("Saliste de la granja");
        }
    }
}
