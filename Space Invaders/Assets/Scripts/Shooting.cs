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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
//         movement = GetComponent<ShipMovement>();
//         shootRight = InputSystem.actions.FindAction("ShootRight");
//         shootLeft = InputSystem.actions.FindAction("ShootLeft");
    }
//
    // Update is called once per frame
    void Update()
    {
//         right = shootRight.ReadValue<float>() > 0f;
//         left = shootLeft.ReadValue<float>() > 0f;
//
//         if (right && left)
//         {
//             timerRight = Mathf.Min(timerRight, timerLeft);
//             timerLeft = Mathf.Min(timerRight, timerLeft);
//         }
//
//         if (right && timerRight >= shootRate)
//         {
//             Shoot(1);
//             timerRight = 0;
//         }
//         else
//         {
//             timerRight += Time.deltaTime;
//         }
//         if (left && timerLeft >= shootRate)
//         {
//             Shoot(-1);
//             timerLeft = 0;
//         }
//         else
//         {
//             timerLeft += Time.deltaTime;
//         }
//
//         if (Mathf.Abs(rotationVelocity) > 0.05)
//         {
//             rotationVelocity = Mathf.MoveTowards(rotationVelocity, 0f, rotationDrag * Time.deltaTime);
//         }
//         else
//         {
//             rotationVelocity = 0;
//         }
//
//         transform.Rotate(new Vector3(0, 0, rotationVelocity * Time.deltaTime));
    }

    void Shoot(float sideFactor)
    {
//         Instantiate(laser, transform.TransformPoint(new Vector3(sideFactor * laserCannonSpacing, 0, 0)), transform.rotation, transform.parent);
//
//         rotationVelocity += sideFactor * shootForce;
//         movement.velocity -= transform.up * knockback;
    }
}
