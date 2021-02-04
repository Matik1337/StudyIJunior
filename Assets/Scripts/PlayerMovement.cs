using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rb.velocity = Vector3.left;
    }
}
