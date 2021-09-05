using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToggleMaterial : MonoBehaviour
{
    [SerializeField] private Material _material;

    private Toggle _toggle;

    public Material Material => _material;
    public event Action<Material> ValueChanged;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener(ToggleChanged);
    }

    private void ToggleChanged(bool value)
    {
        if (value)
            ValueChanged?.Invoke(_material);
    }

    public void ChangeToggle()
    {
        _toggle.isOn = !_toggle.isOn;
    }
}