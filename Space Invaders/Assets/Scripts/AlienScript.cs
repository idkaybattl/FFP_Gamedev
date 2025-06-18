using UnityEngine;

public class AlienScript : MonoBehaviour
{
    GameObject ship;
    public float followForce;

    Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
        rb2D = transform.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.AddForce((ship.transform.position - transform.position).normalized * followForce);
        GravitationHelper.ApplyGravitation(transform, rb2D);
    }
}
