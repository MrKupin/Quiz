using System.Collections.Generic;
using UnityEngine;

public class SelectItemStorage : MonoBehaviour
{
    [SerializeField] private List<ItemStorage> _itemStorage;
    [SerializeField] private SceneItems _sceneItems;

    public void Select()
    {
        int index = Random.Range(0, _itemStorage.Count);
        _sceneItems.Set(_itemStorage[index]);
    }
}
