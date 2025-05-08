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
        Debug.DrawRay(transform.position, direction.normalized * 0.1f, Color.red, 1.0f);
        hits = Physics.RaycastAll(transform.position, direction.normalized, velocity * Time.deltaTime * 100, ~0);

        if (hits.Length > 0) {
            Debug.Log(hits.Length);
            foreach (RaycastHit hit in hits) {
                Destroy(hit.transform.gameObject);
            }

            hasHit = true;
        }

        if (!hasHit && transform.position.x < 10 && transform.position.x > -10 && transform.position.y < 6 && transform.position.y > -6) {
            transform.position = transform.position + (Vector3) direction * velocity * Time.deltaTime;
        } else {
            Destroy(transform.gameObject);
            hasHit = false;
        }
    }
}