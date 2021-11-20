using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPanel : MonoBehaviour
{
    [SerializeField] private GameObject _restart;

    public void Active()
    {
        _restart.SetActive(true);
    }
}
