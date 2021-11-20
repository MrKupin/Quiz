using UnityEngine;
using UnityEngine.Events;

public class LevelCounter : MonoBehaviour
{
    [SerializeField] private int _maxLevel;
    private int _currentlevel;
    public UnityEvent OnNextLevel;
    public UnityEvent OnFinishLevel;

    public void Count()
    {
        _currentlevel++;
        if (_currentlevel >= _maxLevel)
        {
            OnFinishLevel?.Invoke();
            return;
        }
        OnNextLevel?.Invoke();
    }
}
