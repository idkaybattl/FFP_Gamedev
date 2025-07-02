using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;

    public float accelerationForce;

    public float rotationAccelerationForce;

    public float dashForce;
    public float dashDelay;

    public float dashTimer;

    InputAction moveAction;
    InputAction rotateAction;
    InputAction dashAction;
    float moveInput;
    float rotateInput;
    bool dashInput;

    public float dashITime;
    public Animator animator;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rotateAction = InputSystem.actions.FindAction("Rotate");
        dashAction = InputSystem.actions.FindAction("Dash");

        dashTimer = dashDelay;
        animator = GetComponent<Animator>();
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
