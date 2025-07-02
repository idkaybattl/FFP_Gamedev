using Random = UnityEngine.Random;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameState gameState;

    public GameObject ship;
    public GameObject alien;
    public GameObject alienFormation;
    GameObject currentAlienFormation;

    int alienAmnt;
    public Vector2 alienDistanceRange;

    float spawnTime;
    float timer;
    float spawnDelay;
    int currentAmnt;

    float alienAngle;
    float alienDistance;
    float relativeX;
    float relativeY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        alienAmnt = gameState.alienAmnt;
        spawnTime = gameState.alienSpawnTime;
        spawnDelay = spawnTime / alienAmnt;
        SpawnFormation();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnDelay && currentAmnt < alienAmnt)
        {
            SpawnAlien();
            timer = 0;
        }
        timer += Time.deltaTime;
    }


    [ContextMenu("Spawn Formation")]
    void SpawnFormation()
    {
        Destroy(currentAlienFormation);
        currentAlienFormation = Instantiate(alienFormation, transform);
    }

    void SpawnAlien()
    {
        alienAngle = Random.Range(0, 360);
        alienDistance = Random.Range(alienDistanceRange.x, alienDistanceRange.y);
        relativeX = Mathf.Cos(alienAngle) * alienDistance;
        relativeY = Mathf.Sin(alienAngle) * alienDistance;
        Instantiate(alien, new Vector3(relativeX, relativeY, 0) + ship.transform.position, new Quaternion(), currentAlienFormation.transform);
        currentAmnt++;
    }
}
