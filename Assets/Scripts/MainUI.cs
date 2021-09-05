using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [SerializeField] private List<ToggleMaterial> _toggles;
    [SerializeField] private List<Slider> _sliders;
    [SerializeField] private SnowMan _snowman;
    [SerializeField] private List<Preset> _presets;
    [SerializeField] private TMP_Dropdown _dropdownHat;
    [SerializeField] private TMP_Dropdown _dropdownPreset;

    private void Start()
    {
        _toggles.ForEach(toggle => toggle.ValueChanged += OnToggleMaterialValueChanged);
    }

    private void OnToggleMaterialValueChanged(Material material)
    {
        _snowman.ChangeSkin(material);
    }

    public void ChangePreset(int index)
    {
        ApplyPreset(_presets[index]);
    }

    private void ApplyPreset(Preset preset)
    {
        _sliders[0].value = preset.Scales.x;
        _sliders[1].value = preset.Scales.y;
        _sliders[2].value = preset.Scales.z;
        _sliders[3].value = preset.Scales.w;

        _toggles.First(toggle => toggle.Material == preset.Skin).ChangeToggle();

        _dropdownHat.value = (int) preset.Hat;
    }
}