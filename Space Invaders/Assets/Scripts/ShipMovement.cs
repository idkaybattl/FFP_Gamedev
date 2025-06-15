using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;

    public float accelerationForce;

    public float rotationAccelerationForce;

    InputAction moveAction;
    InputAction rotateAction;
    float moveInput;
    float rotateInput;


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
        rb2D.AddTorque(rotateInput * rotationAccelerationForce);

        // move ship
        rb2D.AddRelativeForceY(moveInput * accelerationForce);
    }
}
