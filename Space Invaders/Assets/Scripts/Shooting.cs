using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public float shootRate = 0.3f;
    public float shootForce;

    float timerRight = 0;
    float timerLeft = 0;
    public GameObject laser;
    public float laserCannonSpacing;
    InputAction shootRight;
    InputAction shootLeft;
    bool right;
    bool left;

    float rotationVelocity;
    public float rotationDrag;

    ShipMovement movement;
    public float knockback;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<ShipMovement>();
        shootRight = InputSystem.actions.FindAction("ShootRight");
        shootLeft = InputSystem.actions.FindAction("ShootLeft");
    }

    // Update is called once per frame
    void Update()
    {
        right = shootRight.ReadValue<float>() > 0f;
        left = shootLeft.ReadValue<float>() > 0f;

        if (right && left) {
            timerRight = Mathf.Min(timerRight, timerLeft);
            timerLeft = Mathf.Min(timerRight, timerLeft);
        }

        if (right && timerRight >= shootRate)
        {
            Instantiate(laser, transform.TransformPoint(new Vector3(laserCannonSpacing, 0, 0)), transform.rotation, transform.parent);

            rotationVelocity -= shootForce;
            movement.velocity -= transform.up * knockback;
            timerRight = 0;
        }
        else
        {
            timerRight += Time.deltaTime;
        }
        if (left && timerLeft >= shootRate)
        {
            Instantiate(laser, transform.TransformPoint(new Vector3(-laserCannonSpacing, 0, 0)), transform.rotation, transform.parent);

            rotationVelocity += shootForce;
            movement.velocity -= transform.up * knockback;
            timerLeft = 0;
        }
        else
        {
            timerLeft += Time.deltaTime;
        }

        if (rotationVelocity > 0.05 || rotationVelocity < -0.05)
        {
            rotationVelocity = Mathf.MoveTowards(rotationVelocity, 0f, rotationDrag * Time.deltaTime);
        }
        else
        {
            rotationVelocity = 0;
        }

        transform.Rotate(new Vector3(0, 0, rotationVelocity * Time.deltaTime));
    }
}
