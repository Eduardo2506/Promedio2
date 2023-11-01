using UnityEngine;

public class Planta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<Coseca>().RecojerCultivo(1);
            Destroy(gameObject);
        }
    }
}
