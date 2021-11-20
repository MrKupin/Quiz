using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items")]
public class ItemSO : ScriptableObject
{
    [SerializeField] private SpriteRenderer _icon;
    public SpriteRenderer Icon => _icon;
    private bool _isTarget;
    public bool IsTarget => _isTarget;
    [SerializeField] private string _name;
    public string Name => _name;

    public void MakeTarget()
    {
        _isTarget = !_isTarget;
    }
}