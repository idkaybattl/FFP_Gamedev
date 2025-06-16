using UnityEngine;

public class AlienScript : MonoBehaviour
{
    GameObject ship;
    public float speed;

    Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (ship.transform.position - transform.position).normalized * speed * Time.deltaTime;
    }

    void FixedUpdate() {
        GravitationHelper.ApplyGravitation(transform, rb2D);
    }
}
