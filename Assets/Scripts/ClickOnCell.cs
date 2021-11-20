using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickOnCell : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private EaseInBounce _easeInBounce;
    [SerializeField] private BounceWin _bounceWin;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (TryGetComponent(out Item item))
        {
            if (!item.ItemSO.IsTarget)
                _easeInBounce.Bounce(item.gameObject.transform);
            else
                _bounceWin.Bounce(item.gameObject.transform);
        }
    }
}
