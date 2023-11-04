using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionEscenes : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AnimationClip animacionFinal;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void PasarEscena()
    {
        StartCoroutine(CambiarEscena());
    }
    IEnumerator CambiarEscena()
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene("Promedio2");
    }
}
