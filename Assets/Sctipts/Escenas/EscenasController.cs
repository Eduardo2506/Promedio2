using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenasController : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Promedio2");
    }
    public void Salir()
    {
        Debug.Log("Saliste del juego");
        Application.Quit();
    }
    public void RegresarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
