using System;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        _counter.CounterChanged += UpdateCounter;
    }

    private void OnDisable()
    {
        _counter.CounterChanged -= UpdateCounter;
    }

    public void UpdateCounter()
    {
        _text.text = "Counter: " + _counter.CounterValue;
    }
}
