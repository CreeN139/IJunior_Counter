using System;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public event Action OnButtonPressed;

    private void Update()
    {
        OnButtonClicked();
    }

    private void OnButtonClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Клавиша мыши нажата");
            OnButtonPressed?.Invoke();
        }
    }
}
