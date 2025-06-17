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

    InputAction mouseAction;
    Vector2 mousePosition;

    GameObject[] poles;
    GameObject targetedPole;
    public GameObject target;

    GameObject currentLaser;
    LaserScript currentLaserScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootAction = InputSystem.actions.FindAction("Shoot");
        mouseAction = InputSystem.actions.FindAction("Target");
        rb2D = transform.GetComponent<Rigidbody2D>();

        poles = GameObject.FindGameObjectsWithTag("Pole");
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

        mousePosition = Camera.main.ScreenToWorldPoint((Vector3)mouseAction.ReadValue<Vector2>());
        float minDistance = Vector2.Distance((Vector2)poles[0].transform.position, mousePosition);
        float currentDist;
        targetedPole = poles[0];

        for (int i = 1; i < poles.Length; i++)
        {
            currentDist = Vector2.Distance((Vector2)poles[i].transform.position, mousePosition);
            if (currentDist < minDistance)
            {
                minDistance = currentDist;
                targetedPole = poles[i];
            }
        }

        target.transform.position = targetedPole.transform.position;
    }

    void Shoot()
    {
        currentLaser = Instantiate(laser, transform.TransformPoint((Vector3)Vector2.right * cannonOffset), transform.rotation, transform.parent);
        currentLaser.GetComponent<LaserScript>().Initialize(rb2D.linearVelocity, (Vector2)transform.up, transform.gameObject);

        currentLaser = Instantiate(laser, transform.TransformPoint((Vector3)Vector2.left * cannonOffset), transform.rotation, transform.parent);
        currentLaser.GetComponent<LaserScript>().Initialize(rb2D.linearVelocity, (Vector2)transform.up, transform.gameObject);
    }
}
