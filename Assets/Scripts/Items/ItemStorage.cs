using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{
    [SerializeField] private List<ItemSO> _items;

    public IEnumerable<ItemSO> GetItems()
    {
        foreach (ItemSO item in _items)
        {
            yield return item;
        }
    }
}