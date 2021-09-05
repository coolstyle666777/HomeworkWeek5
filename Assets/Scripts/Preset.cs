using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SnowmanPreset", order = 1)]
public class Preset : ScriptableObject
{
    public Vector4 Scales;
    public Hats Hat;
    public Material Skin;
}
