using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int _counter;
    private bool _isStoped = false;
    private float _delay = 0.5f;
    private bool _isDelayed;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (isStoped() == false)
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
        _text.text = "Counter: " + _counter.ToString();

        yield return new WaitForSeconds(_delay);

        _isDelayed = false;
    }

    private bool isStoped()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return _isStoped = !_isStoped;
        }
        else
        {
            return _isStoped;
        }
    }
}
