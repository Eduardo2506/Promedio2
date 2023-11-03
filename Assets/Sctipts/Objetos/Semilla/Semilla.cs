using UnityEngine;
using System.Collections;

public class Semilla : MonoBehaviour
{
    public GameObject plantaPrefab; 
    public float tiempoDeCrecimiento = 5.0f; 

    private void Start()
    {
        StartCoroutine(CrecerPlanta());
    }

    IEnumerator CrecerPlanta()
    {
        yield return new WaitForSeconds(tiempoDeCrecimiento);

        Instantiate(plantaPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}