using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public float flapStrength = 40;
    public float flapAcceleration = 0.05f;
    public float flapMax = 70;
    public float gravityAcceleration = 0.001f;
    public float gravityMax;
    public bool isAlive = true;
    public LogicScript logic;
    public Rigidbody2D rigidbody2d;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bob Birdington";
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flapStrength < flapMax) {
            flapStrength += flapAcceleration * Time.deltaTime;
        }
        if (rigidbody2d.gravityScale > gravityMax) {
            rigidbody2d.gravityScale += gravityAcceleration * Time.deltaTime;
        }
        if (transform.position.y > 72 || transform.position.y < -72 || transform.position.x < -120 || transform.position.x > 120) {
            logic.gameOver();
            isAlive = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        isAlive = false;
    }
}
