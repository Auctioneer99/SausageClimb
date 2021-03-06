using UnityEngine;

public class SegmentModule : MonoBehaviour
{
    private int _groundLayer = 0;

    private Rigidbody2D _rigidBody;

    public bool IsGrounded => _rigidBody.IsTouchingLayers(_groundLayer);

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _groundLayer = LayerMask.GetMask("ground");
    }
}
