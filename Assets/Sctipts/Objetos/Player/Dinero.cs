using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public int money = 0;
    public Text moneyText; 
    private void Start()
    {
        ActualizarDineroText();
    }

    public bool GastarDinero(int cantidad)
    {
        if (money >= cantidad)
        {
            money -= cantidad;
            ActualizarDineroText(); 
            return true;
        }
        else 
        {
            Debug.Log("No tienes suficiente dinero");
            return false;
        }
    }


    public void GanarDinero(int cantidad)
    {
        money += cantidad;
        ActualizarDineroText(); 
    }

    private void ActualizarDineroText()
    {
        moneyText.text = "Dinero: " + money.ToString();
    }
}
