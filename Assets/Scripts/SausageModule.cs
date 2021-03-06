using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SausageModule : MonoBehaviour
{
    private List<SegmentModule> _segments = new List<SegmentModule>();

    public bool IsGrounded => _segments.Any(seg => seg.IsGrounded);

    void Awake()
    {
        GetComponentsInChildren<SegmentModule>(_segments);
    }
}
