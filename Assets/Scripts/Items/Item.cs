using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemSO _itemSO;
    public ItemSO ItemSO => _itemSO;
    private SpriteRenderer _sprite;

    public void SetItem(ItemSO item)
    {
        _itemSO = item;
        SetImage();
    }

    public void SetImage()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sprite = _itemSO.Icon.sprite;
        _sprite.size = new Vector2(106, 143);
    }
}