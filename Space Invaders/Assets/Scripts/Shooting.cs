using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public float shootRate;

    float timer = 0;
    public GameObject laser;
    public Vector2 cannonOffset;

    Rigidbody2D rb2D;

    InputAction shootAction;
    bool shootInput;

    GameObject currentLaser;
    LaserScript currentLaserScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction = InputSystem.actions.FindAction("Shoot");

        rb2D = transform.GetComponent<Rigidbody2D>();
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
        currentLaser = Instantiate(laser, transform.TransformPoint(new Vector3(cannonOffset.x, cannonOffset.y, 0)), transform.rotation, transform.parent);
        currentLaser.GetComponent<LaserScript>().Initialize(rb2D.linearVelocity, (Vector2)transform.up, transform.gameObject);

        currentLaser = Instantiate(laser, transform.TransformPoint(new Vector3(-cannonOffset.x, cannonOffset.y, 0)), transform.rotation, transform.parent);
        currentLaser.GetComponent<LaserScript>().Initialize(rb2D.linearVelocity, (Vector2)transform.up, transform.gameObject);
    }
}
