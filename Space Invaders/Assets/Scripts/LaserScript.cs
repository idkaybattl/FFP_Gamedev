using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float acceleration = 0.2f;
    public float velocity = 1;
    public float velocityCap = 20;
    public Vector3 direction;
    RaycastHit[] hits;
    bool hasHit;
    GameObject ship;
    float shipDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = transform.rotation * Vector3.up;
        ship = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        shipDistance = (ship.transform.position - transform.position).magnitude;

        if (velocity < velocityCap)
        {
            velocity += acceleration * Time.deltaTime;
        }
        else
        {
            velocity = velocityCap;
        }

        if (!hasHit && shipDistance < 10)
        {
            transform.position = transform.position + (Vector3)direction * velocity * Time.deltaTime;
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(transform.gameObject);
    }
}
