using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    [SerializeField] private Text _clickCountText;
    private int _clickInGameFull;
    private void Start()
    {
        _clickInGameFull = PlayerPrefs.GetInt("Click");
    }

    private void FixedUpdate()
    {
        _clickCountText.text = $"Ваши клики: {_clickInGameFull}";
    }
}
