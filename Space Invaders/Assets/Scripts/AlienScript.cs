using UnityEngine;

public class AlienScript : MonoBehaviour
{
    public GameState gameState;

    GameController gameControllerScript;

    GameObject ship;
    float followForce;
    Vector2 targetPosition;

    bool dead;

    public float lookAheadScale;

    public int hitImpact;

    Rigidbody2D rb2D;

    int health;

    public float repelForce;
    public float repelDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
        rb2D = transform.GetComponent<Rigidbody2D>();

        health = gameState.alienHealth;
        hitImpact = gameState.alienHitImpact;
        followForce = gameState.alienAcceleration;

        gameControllerScript = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        if (dead)
        {
            Destroy(gameObject);
            gameControllerScript.UpdateScore();
        }
    }

    void FixedUpdate()
    {
        targetPosition = (Vector2)ship.transform.position + ship.GetComponent<Rigidbody2D>().linearVelocity * Mathf.Min((ship.transform.position - transform.position).magnitude, 35) * lookAheadScale;

        rb2D.AddForce((targetPosition - (Vector2)transform.position).normalized * followForce);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Vector2 offset = (Vector2)enemy.transform.position - (Vector2)transform.position;
            if (offset.magnitude < repelDistance && offset.magnitude != 0)
            {
                rb2D.AddForce(-offset.normalized * repelForce);
            }
        }
    }

    public void RegisterHit(int hitDamage)
    {
        health -= hitDamage;
        if (health <= 0)
        {
            dead = true;
        }
    }
}
