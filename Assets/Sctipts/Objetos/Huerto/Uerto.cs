using UnityEngine;

public class Uerto : MonoBehaviour
{
    private bool dentroHuerto;
    public int maxSemillasPermitidas = 5;
    private int semillasPlantadas = 0;

    public float tiempoDeReinicio = 60.0f; 

    private float tiempoTranscurrido = 0.0f;
    private bool reinicioProgramado = false;
    private void Update()
    {
        if (reinicioProgramado)
        {
            tiempoTranscurrido += Time.deltaTime;
            if (tiempoTranscurrido >= tiempoDeReinicio)
            {
                ReiniciarContador();
            }
        }
    }
    public bool PuedesPlantarSemilla()
    {
        return dentroHuerto && semillasPlantadas < maxSemillasPermitidas;
    }

    public void IncrementarSemillasPlantadas()
    {
        semillasPlantadas++;
        reinicioProgramado = true;
        tiempoTranscurrido = 0.0f;
    }
    private void ReiniciarContador()
    {
        semillasPlantadas = 0;
        reinicioProgramado = false;
        Debug.Log("El contador de semillas se ha reiniciado.");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroHuerto = true;
            Debug.Log("Entraste a la huerto");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentroHuerto = false;
            Debug.Log("Saliste de la huerto");
        }
    }
}
