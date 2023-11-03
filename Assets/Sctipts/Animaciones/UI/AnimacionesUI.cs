using UnityEngine;

public class AnimacionesUI : MonoBehaviour
{
    [SerializeField] private GameObject fondoNegro;
    [SerializeField] private GameObject animEntradaWin;

    public void AnimacionEntradaWIn()
    {
        LeanTween.scale(animEntradaWin.GetComponent<RectTransform>(), new Vector3(2, 2, 2), 0.5f).setDelay(0.5f).setEase(LeanTweenType.easeOutBack);
        LeanTween.alpha(fondoNegro.GetComponent<RectTransform>(), 0.5f, 1f);
    }
    public void AnimacionSalidaWin()
    {
        LeanTween.scale(animEntradaWin.GetComponent<RectTransform>(), new Vector3(0, 0, 0), 0.5f);
        LeanTween.alpha(fondoNegro.GetComponent<RectTransform>(), 0.5f, 1f);
    }
}
