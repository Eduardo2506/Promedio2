using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vender : MonoBehaviour
{
    public float precioSemilla = 100;
    public float extra;
    private void Start()
    {
        extra = precioSemilla*2;
    }
    public void VenderSemilla(Dinero dinero)
    {
        dinero.money += precioSemilla + extra;
        dinero.ActualizarMoney();
        
        Destroy(gameObject);
    }

}
