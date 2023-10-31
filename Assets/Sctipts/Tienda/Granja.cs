using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granja : MonoBehaviour
{
    public Transform spawnSemilla;
    public GameObject prefabSemilla;
    public float tiempoCosechar = 0.5f;

    private bool tieneSemilla;
    private float tiempoPlantar = 0.0f;

    private void Update()
    {
        if (tieneSemilla)
        {
            tiempoPlantar += Time.deltaTime;
        }
        if (tiempoPlantar >= tiempoCosechar)
        {
            RecogerCultivo();
        }
    }
    public void ComprarSemilla()
    {
        Dinero dinero = FindObjectOfType<Dinero>();
        if (dinero != null && dinero.money >= 50)
        {
            dinero.GastarMoney(50);
            tieneSemilla = true;
            tiempoPlantar = 0.0f;

            Instantiate(prefabSemilla, spawnSemilla.position, Quaternion.identity);
        }
    }
    public void RecogerCultivo()
    {
        if (tieneSemilla)
        {
            if (tiempoPlantar >= tiempoCosechar)
            {
                Destroy(spawnSemilla.GetChild(0).gameObject);
                tieneSemilla = false;
                tiempoPlantar = 0.0f;
            }
            else
            {
                Debug.Log("La cosecha aun no esta lista para recoger");
            }
        }
    }
}
