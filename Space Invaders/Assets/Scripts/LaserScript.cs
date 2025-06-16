using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float extraVelocity;

    Rigidbody2D rb2D;

    RaycastHit[] hits;
    bool hasHit;
    GameObject ship;
    float shipDistance;
    public float gravitationConstant;

    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        shipDistance = (ship.transform.position - transform.position).magnitude;

        if (hasHit || shipDistance > 10)
        {
            Destroy(transform.gameObject);
        }

        // rotate laser towards velocity direction
        if (rb2D.linearVelocity.magnitude > 0.1)
        {
            float targetAngle = Mathf.Atan2(rb2D.linearVelocity.y, rb2D.linearVelocity.x) * Mathf.Rad2Deg - 90;
            Debug.Log(targetAngle);
            Quaternion targetRotation = Quaternion.Euler(0, 0, targetAngle);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    public void Initialize(Vector2 startingVelocity, Vector2 direction, GameObject shipObject)
    {
        rb2D.linearVelocity = startingVelocity + direction * extraVelocity;
        ship = shipObject;
    }

    void FixedUpdate()
    {
        GameObject[] heavyObjects = GameObject.FindGameObjectsWithTag("Heavy");

        foreach (GameObject heavyObject in heavyObjects)
        {
            Vector2 offset = (Vector2)heavyObject.transform.position - (Vector2)transform.position;
            if (offset.magnitude > 0.5f)
            {
                rb2D.AddForce((offset.normalized * heavyObject.GetComponent<Rigidbody2D>().mass * gravitationConstant) / Mathf.Pow(offset.magnitude / 3, 2));
            }
        }
    }
}
