using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryInspector : MonoBehaviour
{
    [SerializeField]
    private PlayerUI _ui;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _ui.Win();
        }
    }
}
