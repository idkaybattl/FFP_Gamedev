using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public float shootRate = 0.3f;
    float timerRight = 0;
    float timerLeft = 0;
    public GameObject laser;
    public float laserCannonSpacing;
    InputAction shootRight;
    InputAction shootLeft;
    bool right;
    bool left;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootRight = InputSystem.actions.FindAction("ShootRight");
        shootLeft = InputSystem.actions.FindAction("ShootLeft");
    }

    // Update is called once per frame
    void Update()
    {
        right = shootRight.ReadValue<float>() > 0f;
        left = shootLeft.ReadValue<float>() > 0f;

        if (right && timerRight >= shootRate)
        {
            Instantiate(laser, transform.TransformPoint(new Vector3(laserCannonSpacing, 0, 0)), transform.rotation, transform.parent);
            timerRight = 0;
        }
        else
        {
            timerRight += Time.deltaTime;
        }
        if (left && timerLeft >= shootRate)
        {
            Instantiate(laser, transform.TransformPoint(new Vector3(-laserCannonSpacing, 0, 0)), transform.rotation, transform.parent);
            timerLeft = 0;
        }
        else
        {
            timerLeft += Time.deltaTime;
        }
    }
}
