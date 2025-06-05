using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class ShipMovement : MonoBehaviour
{
    public Vector3 velocity = new();
    public float acceleration;
    public float velocityCap;
    public float friction;
    public float rotationVelocity;
    public float rotationAcceleration;
    public float rotationVelocityCap;
    public float rotationFriction;
    Vector3 mouseWorldSpace;
    InputAction inputAction;
    float input;
    Vector3 moveVector;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputAction = InputSystem.actions.FindAction("Engine");
    }

    // Update is called once per frame
    void Update()
    {
        input = inputAction.ReadValue<float>();

        
        // move ship
        moveVector = transform.up * input;

        if (input != 0 || velocity.magnitude > 0.05)
        {
            velocity += moveVector * acceleration * Time.deltaTime;
            velocity += velocity.normalized * -friction * Time.deltaTime;

            velocity = Vector2.ClampMagnitude(velocity, velocityCap);

            transform.position += (Vector3)velocity * Time.deltaTime;
        }
        else
        {
            velocity = new();
        }
    }
}
