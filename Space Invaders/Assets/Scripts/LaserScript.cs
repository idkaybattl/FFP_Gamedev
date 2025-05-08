using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float acceleration = 0.2f;
    public float velocity = 1;
    public float velocityCap = 20;
    public Vector3 direction;
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

        RaycastHit[] hits;
        hits = Physics.RaycastAll(new Ray(transform.position, direction), velocity * Time.deltaTime);

        if (hits.Length > 0) {
            foreach (RaycastHit hit in hits) {
                Destroy(hit.transform.gameObject);
            }

            hasHit = true;
        }

        if (!hasHit && transform.position.x < 10 && transform.position.x > -10 && transform.position.y < 6 && transform.position.y > -6) {
            transform.position = transform.position + (Vector3) direction * velocity * Time.deltaTime;
        } else {
            Destroy(transform.gameObject);
        }
    }
}