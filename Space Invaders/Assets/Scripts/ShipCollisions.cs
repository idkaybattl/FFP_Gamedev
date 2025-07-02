using UnityEngine;

public class ShipCollisions : MonoBehaviour
{
    public GameObject gameController;
    GameController gameControllerScript;
    public GameState gameState;

    float hitITime;
    float currentITime;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameControllerScript = gameController.GetComponent<GameController>();

        hitITime = gameState.hitITime;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (timer > currentITime && other.CompareTag("Enemy"))
        {
            gameControllerScript.RegisterHit(other.GetComponent<AlienScript>().hitImpact);

            startIFrames(hitITime);
        }
    }

    public void startIFrames(float iTime)
    {
        timer = 0;
        currentITime = iTime;
    }
}
