using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float acceleration = 0.2f;
    public float velocity = 1;
    public float velocityCap = 20;
    public Vector3 direction;
    RaycastHit[] hits;
    bool hasHit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = transform.rotation * Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity < velocityCap) {
            velocity += acceleration * Time.deltaTime;
        } else {
            velocity = velocityCap;
        }
        
        if (!hasHit && transform.position.x < 10 && transform.position.x > -10 && transform.position.y < 6 && transform.position.y > -6) {
            transform.position = transform.position + (Vector3) direction * velocity * Time.deltaTime;
        } else {
            Destroy(transform.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(other.gameObject);
        Destroy(transform.gameObject);
    }
}
