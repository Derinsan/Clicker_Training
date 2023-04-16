using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayControl : MonoBehaviour
{
    private int _clickCount;
    [SerializeField] private Text _clickText;

    public void ClickCube()
    {
        _clickCount++;
        PlayerPrefs.SetInt("Click", _clickCount);
    }

    private void FixedUpdate()
    {
        _clickText.text = $"{_clickCount}";
    }
}
