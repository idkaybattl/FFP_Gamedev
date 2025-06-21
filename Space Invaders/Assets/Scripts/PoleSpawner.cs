using UnityEngine;
using Random = UnityEngine.Random;

public class PoleSpawner : MonoBehaviour
{
    public GameObject pole;
    public Vector2 area;
    public int amnt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < amnt; i++)
        {
            Vector2 position = new Vector2(Random.Range(0, area.x) - area.x / 2, Random.Range(0, area.y) - area.y / 2);
            Instantiate(pole, position, new Quaternion(), transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
