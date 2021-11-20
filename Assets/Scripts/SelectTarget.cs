using UnityEngine;
using System.Collections.Generic;

public class SelectTarget : MonoBehaviour
{
    [SerializeField] private SceneItems _sceneItems;
    [SerializeField] private DisplayTarget _displayTarget;
    [SerializeField] private List<ItemSO> _lastTargets;

    public void Select()
    {
        int index = Random.Range(0, _sceneItems.Items.Count);
        foreach (ItemSO target in _lastTargets)
        {
            if (_sceneItems.Items[index].ItemSO.Name == target.Name)
            {
                Select();
                return;
            }
        }
        _lastTargets.Add(_sceneItems.Items[index].ItemSO);
        _sceneItems.Items[index].ItemSO.MakeTarget();
        _displayTarget.Display(_sceneItems.Items[index].ItemSO.Name);
    }
}
