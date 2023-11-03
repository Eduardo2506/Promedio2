using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coseca : MonoBehaviour
{
    public int cantidadDeCosecha = 0;
    public TextMeshProUGUI cosechaText;
    private void Start()
    {
        ActualizarCosechaUI();
    }
    public void RecojerCultivo(int cantidad)
    {
        cantidadDeCosecha += cantidad;
        ActualizarCosechaUI();
    }

    public bool VenderCosecha(int cantidad)
    {
        if (cantidadDeCosecha >= cantidad)
        {
            cantidadDeCosecha -= cantidad;
            FindObjectOfType<Dinero>().GanarDinero(cantidad);
            ActualizarCosechaUI();
            return true;
        }
        else
        {
            Debug.Log("No tienes suficiente cosecha para vender.");
            return false;
        }
    }

    void ActualizarCosechaUI()
    {
        cosechaText.text = "" + cantidadDeCosecha.ToString();
    }
}
