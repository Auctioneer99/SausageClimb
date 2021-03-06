using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageFollower : MonoBehaviour
{
    [SerializeField]
    private Transform _targetTransform;
    private Transform _transform;

    void Start()
    {
        _transform = this.transform;
    }

    void Update()
    {
        _transform.position = new Vector3(_targetTransform.position.x, _targetTransform.position.y, _transform.position.z);
    }
}
