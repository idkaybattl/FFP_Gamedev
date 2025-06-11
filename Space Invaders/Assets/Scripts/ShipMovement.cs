using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public Vector3 velocity = new();
    public float acceleration;
    public float velocityCap;
    public float friction;

    public float rotationVelocity = 0;
    public float rotationAcceleration;
    public float rotationVelocityCap;
    public float rotationFriction;

    InputAction moveAction;
    InputAction rotateAction;
    float moveInput;
    float rotateInput;
    Vector3 moveVector;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rotateAction = InputSystem.actions.FindAction("Rotate");
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<float>();
        rotateInput = rotateAction.ReadValue<float>();

        // rotate ship
        if (rotateInput != 0 || Mathf.Abs(rotationVelocity) > 0.05)
        {
            rotationVelocity += rotateInput * rotationAcceleration * Time.deltaTime;
            rotationVelocity = Mathf.MoveTowards(rotationVelocity, 0f, rotationFriction * Time.deltaTime);

            rotationVelocity = Mathf.Clamp(rotationVelocity, -rotationVelocityCap, rotationVelocityCap);

            transform.Rotate(new Vector3(0, 0, -rotationVelocity * Time.deltaTime));
        }
        else
        {
            rotationVelocity = 0;
        }

        // move ship
        moveVector = transform.up * moveInput;

        if (moveInput != 0 || velocity.magnitude > 0.05)
        {
            velocity += moveVector * acceleration * Time.deltaTime;
            velocity -= velocity.normalized * friction * Time.deltaTime;

            velocity = Vector2.ClampMagnitude(velocity, velocityCap);

            transform.position += velocity * Time.deltaTime;
        }
        else
        {
            velocity = new();
        }
    }
}
