﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithForceUseTransformRotationClampVelocity : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float _movementForce = 10f;
    [SerializeField] private double _maximumVelocity = 10f;

    private void Awake() => _rigidbody = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        if (_rigidbody.velocity.magnitude >= _maximumVelocity)
            return;

        if (Input.GetKey(KeyCode.W))
            _rigidbody.AddForce(_movementForce * Vector3.forward);

        if (Input.GetKey(KeyCode.S))
            _rigidbody.AddForce(_movementForce * Vector3.back);

        if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_movementForce * Vector3.right);

        if (Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(_movementForce * Vector3.left);
    }
}
