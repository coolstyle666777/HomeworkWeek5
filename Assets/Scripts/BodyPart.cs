using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    [SerializeField] private List<MeshRenderer> _renderers;

    public void SetScale(float value)
    {
        transform.localScale = Vector3.one * value;
    }

    public void SetMaterial(Material material)
    {
        _renderers.ForEach(renderer => renderer.material = material);
    }
}