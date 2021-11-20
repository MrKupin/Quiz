using DG.Tweening;
using System.Collections;
using UnityEngine;

public class BounceWin : MonoBehaviour
{
    private Sequence _sequence;
    [SerializeField] private ParticlesStars _particlesStars;
    private LevelCounter _levelCounter;
    private bool _isPlaying;

    private void Start()
    {
        _sequence = DOTween.Sequence();
        _levelCounter = FindObjectOfType<LevelCounter>();
    }

    public void Bounce(Transform objectTransform)
    {
        if (!_isPlaying)
        {
            _sequence = DOTween.Sequence();
            _particlesStars.Play();
            _sequence.Append(objectTransform.DOScale(1.2f, 1.5f)).Append(objectTransform.DOScale(1, 1.5f)).onComplete += StoppingPlay;
            _isPlaying = true;
        }
    }

    private void StoppingPlay()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        _particlesStars.Stop();
        yield return new WaitForSeconds(0.7f);
        _levelCounter.Count();
        _isPlaying = false;
    }
}
