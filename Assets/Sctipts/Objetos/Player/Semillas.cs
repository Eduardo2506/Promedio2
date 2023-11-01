using UnityEngine;
using UnityEngine.UI;

public class Semillas : MonoBehaviour
{
    public int cantidadSemillas = 0;
    public Text semillasText;
    private bool canPlant = false; 
    public GameObject semillaPrefab;
    public Transform puntoPlantacion;
    private Dinero dinero;
    private Uerto uerto;//
    private void Start()
    {
        ActualizarSemillasUI();
        dinero = FindObjectOfType<Dinero>();
        uerto = FindObjectOfType<Uerto>();//
    }
    void Update()
    {
        if (canPlant && cantidadSemillas > 0 && Input.GetKeyDown(KeyCode.P))
        {
            PlantarSemilla();
        }
    }
    public void PlantarSemilla()
    {
        if (/*canPlant*/uerto.PuedesPlantarSemilla() && cantidadSemillas > 0)
        {
            cantidadSemillas--;
            Instantiate(semillaPrefab, puntoPlantacion.position, Quaternion.identity);
            ActualizarSemillasUI();
            uerto.IncrementarSemillasPlantadas();

        }
        else if (!uerto.PuedesPlantarSemilla())
        {
            Debug.Log("El huerto alcanzó su capacidad máxima de semillas");
        }
        else
        {
            Debug.Log("No tienes suficientes semillas para plantar");
        }
    }

    public void ObtenerSemillas(int cantidad)
    {
        if (dinero.GastarDinero(10))
        {
            cantidadSemillas += cantidad;
            ActualizarSemillasUI();
        }

    }

    void ActualizarSemillasUI()
    {
        semillasText.text = "Semillas: " + cantidadSemillas.ToString();
    }   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Huerto"))
        {
            canPlant = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Huerto"))
        {
            canPlant = false;
        }
    }
}
