using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    Vector2 moveInput;
    Rigidbody2D rb;
    public GameObject SemillaPrefab;
    public Transform PuntoDePlantacion;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.P))
        {
            PlantarSemilla();
        }
    }

    void PlantarSemilla()
    {
        Instantiate(SemillaPrefab, PuntoDePlantacion.position, Quaternion.identity);
        Debug.Log("¡Semilla Plantada!");
    }

}
