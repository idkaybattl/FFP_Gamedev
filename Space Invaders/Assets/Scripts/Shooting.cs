using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public float shootRate;

    float timer = 0;
    public GameObject laser;
    public Vector2 cannonOffset;

    InputAction shootAction;
    bool shootInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction = InputSystem.actions.FindAction("Shoot");
    }

    // Update is called once per frame
    void Update()
    {
        shootInput = shootAction.ReadValue<float>() != 0;

        if (shootInput && timer > shootRate)
        {
            Shoot();
            timer = Time.deltaTime;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void Shoot()
    {
        Instantiate(laser, transform.TransformPoint((Vector3)Vector2.right * cannonOffset),transform.rotation, transform.parent);
        Instantiate(laser, transform.TransformPoint((Vector3)Vector2.left * cannonOffset), transform.rotation, transform.parent);
    }
}
