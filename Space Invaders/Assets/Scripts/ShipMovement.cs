using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public Vector3 velocity = new();
    public float acceleration;
    public float velocityCap;
    public float friction;
    InputAction inputAction;
    Vector2 input;
    Vector3 moveVector;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        input = inputAction.ReadValue<Vector2>();

        
        // move ship
        moveVector = transform.TransformDirection(input);

        if (input.magnitude != 0 || velocity.magnitude > 0.05)
        {
            velocity += moveVector * acceleration * Time.deltaTime;
            velocity += velocity.normalized * -friction * Time.deltaTime;

            velocity = Vector2.ClampMagnitude(velocity, velocityCap);

            transform.position += velocity * Time.deltaTime;
        }
        else
        {
            velocity = new();
        }
    }
}
