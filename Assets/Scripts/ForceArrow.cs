using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ForceArrow : MonoBehaviour
{
    private bool _isDragging = false;
    private float _x, _y;

    [SerializeField]
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private Transform _mainSegment;
    private SausageModule _sausage;

    [SerializeField]
    private int power;

    [SerializeField]
    private GameObject _arrowPrefab;
    private GameObject _arrow;

    private void Awake()
    {
        _sausage = GetComponent<SausageModule>();
    }

    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        if (_arrow != null)
        {
            Transform transform = _arrow.transform;
            Vector3 vec = new Vector3(x, -y, 0);
            transform.rotation = Quaternion.FromToRotation(vec, Vector3.up);
            transform.localScale = new Vector3(1, vec.sqrMagnitude, 1);
        }

        if (x != 0 || y != 0)
        {
            if (_sausage.IsGrounded)
            {
                if (_isDragging == false)
                {
                    _arrow = Instantiate(_arrowPrefab, _mainSegment);
                    _isDragging = true;
                }
            }
        }
        else
        {
            if (_isDragging == true)
            {
                Destroy(_arrow);
                _arrow = null;
                Release(-new Vector2(_x, _y));
                _isDragging = false;
            }
        }
        _x = x;
        _y = y;
    }

    private void Release(Vector2 direction)
    {
        _rigidBody.AddForce(direction * power, ForceMode2D.Impulse);
    }
}
