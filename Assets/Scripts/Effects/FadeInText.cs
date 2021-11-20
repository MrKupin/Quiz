using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeInText : MonoBehaviour
{
    [SerializeField] private Text _text;
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
