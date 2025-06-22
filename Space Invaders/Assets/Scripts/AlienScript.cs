using UnityEngine;

public class AlienScript : MonoBehaviour
{
    GameObject ship;
    public float followForce;

    public int hitImpact;

    Rigidbody2D rb2D;

    public int maxHealth;
    int health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
        rb2D = transform.GetComponent<Rigidbody2D>();

        health = maxHealth;
    }

    void FixedUpdate()
    {
        rb2D.AddForce((ship.transform.position - transform.position).normalized * followForce);
        GravitationHelper.ApplyGravitation(transform, rb2D);
    }

    public void RegisterHit(int hitDamage)
    {
        health -= hitDamage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
