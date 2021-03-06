using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private Text _gameProgress;

    public void Win()
    {
        Debug.Log("WIN!!!");
        _gameProgress.text = "WIN!!!";
    }
}
