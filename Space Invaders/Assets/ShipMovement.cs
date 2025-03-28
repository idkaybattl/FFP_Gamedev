using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class ShipMovement : MonoBehaviour
{
    public Vector2 velocity = new();
    public float acceleration;
    public float velocityCap;
    public float friction;
    InputAction moveAction;
    Vector2 inputMoveVector;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        inputMoveVector = moveAction.ReadValue<Vector2>();

        if (inputMoveVector != new Vector2() || velocity.magnitude > 0.05) {

            velocity += inputMoveVector * acceleration * Time.deltaTime;
            velocity = Vector2.ClampMagnitude(velocity, velocityCap);

            velocity += velocity.normalized * -friction * Time.deltaTime;

            Debug.Log(velocity.magnitude);

            transform.position += (Vector3)velocity * Time.deltaTime;
        }
        else {
            velocity = new();
        }
    }
}
