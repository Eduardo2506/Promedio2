using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenasController : MonoBehaviour
{
    public GameObject teclas;
    public GameObject especificaciones;
    public GameObject lore;
    public GameObject panelPausa;
    public GameObject panelDesactivar;
    //public AudioSource botonsound;
    //private void Start()
    //{
    //    botonsound = GetComponent<AudioSource>();
    //}
    public void Jugar()
    {
        //botonsound.Play();
        SceneManager.LoadScene("Promedio2");
    }
    public void Salir()
    {
        //botonsound.Play();
        Debug.Log("Saliste del juego");
        Application.Quit();
    }
    public void RegresarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Controles()
    {
        //botonsound.Play();
        SceneManager.LoadScene("Controles");
    }

    public void Teclas()
    {
        lore.SetActive(false);
        teclas.SetActive(true);
    }
    public void Especificaciones()
    {
        teclas.SetActive(false);
        especificaciones.SetActive(true);
    }
    public void Pause()
    {
        panelDesactivar.SetActive(false);
        panelPausa.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Play()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseForzaor()
    {
        //panelDesactivar.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
