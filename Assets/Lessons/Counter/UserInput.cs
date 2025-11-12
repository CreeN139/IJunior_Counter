using UnityEngine;

public class UserInput : MonoBehaviour
{
    private bool _isStoped = false;

    public bool IsStoped()
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
