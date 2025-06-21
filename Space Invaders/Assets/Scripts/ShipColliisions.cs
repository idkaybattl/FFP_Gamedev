using UnityEngine;

public class ShipColliisions : MonoBehaviour
{
    public GameObject gameController;
    GameController gameControllerScript;

    public float iTime;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameControllerScript = gameController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (timer > iTime && other.CompareTag("Enemy"))
        {
            gameControllerScript.RegisterHit(other.GetComponent<AlienScript>().hitImpact);
            timer = 0;
        }
    }
}
