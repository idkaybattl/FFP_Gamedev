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
    InputAction moveAction;
    Vector2 inputMoveVector;
    Vector3 moveVector;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        inputMoveVector = moveAction.ReadValue<Vector2>();

        // rotate ship
        if (inputMoveVector.x != 0 || rotationVelocity > 0.05 || rotationVelocity < -0.05)
        {
            Debug.Log("yay");
            rotationVelocity += inputMoveVector.x * rotationAcceleration * Time.deltaTime;
            rotationVelocity = Mathf.MoveTowards(rotationVelocity, 0f, rotationFriction * Time.deltaTime);

            rotationVelocity = Mathf.Clamp(rotationVelocity, -rotationVelocityCap, rotationVelocityCap);

            transform.Rotate(0, 0, -rotationVelocity * Time.deltaTime);
        }
        else
        {
            rotationVelocity = 0;
        }


        // move ship
        moveVector = transform.up * inputMoveVector.y;

        if (inputMoveVector.y != 0 || velocity.magnitude > 0.05)
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
