using UnityEngine;

public class CreateCell : MonoBehaviour
{
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private Transform _parent;
    [SerializeField] private int _quantityToCreate;
    [SerializeField] private SceneItems _setItems;
    [SerializeField] private SelectItemStorage _selectStorage;

    private void Start()
    {
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < _quantityToCreate; i++)
        {
            GameObject cell = Instantiate(_cellPrefab, _parent);
            _setItems.SetNumberOfItems(cell.transform.GetChild(0).GetComponent<Item>());
        }
        _selectStorage.Select();
    }
}