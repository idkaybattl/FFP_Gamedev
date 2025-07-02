using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameState gameState;

    float accelerationForce;

    float rotationAccelerationForce;

    float dashForce;
    float dashDelay;

    public float dashTimer;

    InputAction moveAction;
    InputAction rotateAction;
    InputAction dashAction;
    float moveInput;
    float rotateInput;
    bool dashInput;

    float dashITime;
    public Animator animator;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rotateAction = InputSystem.actions.FindAction("Rotate");
        dashAction = InputSystem.actions.FindAction("Dash");

        animator = GetComponent<Animator>();

        accelerationForce = gameState.shipAcceleration;
        rotationAccelerationForce = gameState.shipRotation;
        dashForce = gameState.dashForce;
        dashDelay = gameState.dashDelay;
        dashITime = gameState.dashITime;

        dashTimer = dashDelay;
    }

    void Update()
    {
        moveInput = moveAction.ReadValue<float>();
        rotateInput = rotateAction.ReadValue<float>();
        dashInput = dashAction.ReadValue<float>() > 0;

        moveInput = moveInput < 0 ? moveInput * 0.5f : moveInput;

        if (dashInput && dashTimer > dashDelay)
        {
            rb2D.AddRelativeForceY(dashForce, ForceMode2D.Impulse);

            GetComponent<ShipCollisions>().startIFrames(dashITime);
            animator.SetTrigger("DashTrigger");
            dashTimer = Time.deltaTime;
        }
        else
        {
            dashTimer += Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        // rotate ship
        rb2D.AddTorque(rotateInput * rotationAccelerationForce);

        // move ship
        rb2D.AddRelativeForceY(moveInput * accelerationForce);
    }
}
