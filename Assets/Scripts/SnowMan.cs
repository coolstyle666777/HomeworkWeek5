using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnowMan : MonoBehaviour
{
    [SerializeField] private List<BodyPart> _bodyParts;
    [SerializeField] private List<GameObject> _hats;

    public void ChangeSkin(Material material)
    {
        _bodyParts.ForEach(part => part.SetMaterial(material));
    }

    public void ChangeHat(int index)
    {
        for (int i = 0; i < _hats.Count; i++)
        {
            _hats[i].SetActive(i == index);
        }
    }
}

public enum Hats
{
    BlackHat,
    Police,
    Snow,
    None
}