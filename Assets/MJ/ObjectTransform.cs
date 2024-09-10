using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    [SerializeField] private Transform _StandingTransform;

    private void Update()
    {
        transform.position = _StandingTransform.position;
    }
}
