using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    [SerializeField] public float money;
    [SerializeField] private Text moneyText;

    private void Start()
    {
        ActualizarMoney();
    }
    public void ActualizarMoney()
    {
        moneyText.text = "Dinero: $" + money.ToString();
    }
    public void GastarMoney(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            ActualizarMoney();
        }
        else
        {
            Debug.Log("No tiene suficiente dinero para comprar");
        }
    }

}
