using Random = UnityEngine.Random;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject alien;
    public GameObject alienFormation;
    GameObject currentAlienFormation;

    public int alienAmnt;
    public float alienAngleRange;
    public Vector2 alienDistanceRange;

    float alienAngle;
    float alienDistance;
    float relativeX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnFormation();
    }

    // Update is called once per frame
    void Update()
    {

    }


    [ContextMenu("Spawn Formation")]
    void SpawnFormation()
    {
        Destroy(currentAlienFormation);
        currentAlienFormation = Instantiate(alienFormation, transform);
        for (int i = 0; i < alienAmnt; i++) {
            alienAngle = Random.Range(0, alienAngleRange) - alienAngleRange / 2;
            alienDistance = Random.Range(alienDistanceRange.x, alienDistanceRange.y);
            relativeX = Mathf.Sin(alienAngle / 2) * alienDistance;
            Instantiate(alien, new Vector3(relativeX, Mathf.Sqrt(Mathf.Pow(alienDistance, 2) + Mathf.Pow(relativeX, 2)), 0), new Quaternion(), currentAlienFormation.transform);
        }
    }
}
