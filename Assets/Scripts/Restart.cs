using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _loadingScreen;
    private AsyncOperation _asyncOperation;

    public void Load(int scene)
    {
        _loadingScreen.DOFade(1, 2).onComplete += Loaded;
        _asyncOperation = SceneManager.LoadSceneAsync(scene);
        _asyncOperation.allowSceneActivation = false;
    }

    private void Loaded()
    {
        _asyncOperation.allowSceneActivation = true;
    }
}
