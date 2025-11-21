using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    private int _counter;
    private WaitForSeconds _pause;
    private float _delay = 0.5f;
    private bool _isStoped;

    public event Action CounterChanged;

    public int CounterValue => _counter;

    private void Awake()
    {
        _pause = new WaitForSeconds(_delay);
        _counter = 0;
        _isStoped = false;
    }

    private void Start()
    {
        StartCoroutine(nameof(Count));
    }

    private void OnEnable()
    {
        _userInput.OnButtonPressed += ChangeState;
    }

    private void OnDisable()
    {
        _userInput.OnButtonPressed -= ChangeState;
    }

    private void ChangeState()
    {
        if (_isStoped)
        {
            StartCoroutine(nameof(Count));
        }
        else
        {
            StopCoroutine(nameof(Count));
        }

        _isStoped = !_isStoped;
    }

    private IEnumerator Count()
    {
        while (true)
        {
            _counter++;
            CounterChanged?.Invoke();
            yield return _pause;
        }
    }
}
