using DG.Tweening;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private Transform _object;

    public void Start()
    {
        _object.DOScale(1, 1);
    }
}
