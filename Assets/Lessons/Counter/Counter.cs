using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    private int _counter = 0;
    private WaitForSeconds _pause;
    private float _delay = 0.5f;
    private bool _isDelayed;

    public int CounterValue => _counter;

    private void Awake()
    {
        _pause = new WaitForSeconds(_delay);
    }

    private void Update()
    {
        if (_userInput.IsStoped() == false)
        {
            if (_isDelayed == false)
            {
                StartCoroutine("Count");
            }
        }
    }

    private IEnumerator Count()
    {
        _isDelayed = true;
        _counter++;
        yield return _pause;
        _isDelayed = false;
    }
}
