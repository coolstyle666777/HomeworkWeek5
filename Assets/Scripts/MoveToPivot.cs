using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class MoveToPivot : MonoBehaviour
{
    [SerializeField] private Transform _pivot;

    private void Update()
    {
        transform.position = _pivot.position;
    }
}