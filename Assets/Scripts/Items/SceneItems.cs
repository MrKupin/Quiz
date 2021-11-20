using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneItems : MonoBehaviour
{
    [SerializeField] private List<Item> _items;
    public List<Item> Items => _items;
    [SerializeField] private SelectTarget _selectTarget;

    public void Set(ItemStorage storage)
    {
        List<ItemSO> items = new List<ItemSO>();
        foreach (ItemSO item in storage.GetItems())
        {
            items.Add(Instantiate(item));
        }
        int index;
        for (int i = 0; i < _items.Count; i++)
        {
            index = Random.Range(0, items.Count);
            _items[i].SetItem(items[index]);
            items.RemoveAt(index);
        }
        _selectTarget.Select();
    }

    public void SetNumberOfItems(Item item)
    {
        _items.Add(item);
    }
}
