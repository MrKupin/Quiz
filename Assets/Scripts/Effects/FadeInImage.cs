using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeInImage : MonoBehaviour
{
    [SerializeField] private Image _text;
    [SerializeField] private float _saturation;

    public void Start()
    {
        Fade();
    }

    public void Fade()
    {
        _text.DOFade(_saturation, 3);
    }
}
