using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiagramFiller : MonoBehaviour
{
    [SerializeField] private Image _diagramFill;

    [Range(0f, 1f)] [SerializeField] private float _currentCount;
    [SerializeField] private UIChanger _uIChanger;

    private float _previousCount;

    private void Start()
    {
        _previousCount = _currentCount;
        Filler();
    }

    private void Filler()
    {
        _diagramFill.fillAmount = _currentCount;
        _uIChanger.TextPercentFiller(_currentCount);
    }
   
    private void CheckChangedValue()
    {
        if (_currentCount != _previousCount)
        {
            Filler();
            _previousCount = _currentCount;
        }
    }

    private void Update()
    {
        CheckChangedValue();
    }
}
