using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTarget : MonoBehaviour
{
    [SerializeField] private Text _target;

    public void Display(string text)
    {
        _target.text = "Find " + text; 
    }
}
