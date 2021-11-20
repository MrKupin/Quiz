using DG.Tweening;
using UnityEngine;

public class EaseInBounce : MonoBehaviour
{
    private bool _isPlaying;

    public void Bounce(Transform objectTransform)
    {
        if (!_isPlaying)
        {
            _isPlaying = true;
            objectTransform.DOShakeScale(1, 1).onComplete += StoppingPlay;
        }
    }

    private void StoppingPlay()
    {
        _isPlaying = false;
    }
}
