using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public int alienLevel;

    public enum Shapes {
        Rectangle,
        Circle,
        Triangle
    }

    public Shapes shapeOptions;

    public GameObject RectangleSpawner;
    public GameObject CircleSpawner;
    public GameObject TriangleSpawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnAliens();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAliens()
    {
        if (shapeOptions == Shapes.Rectangle) {
            Instantiate(RectangleSpawner);
        }
        else if (shapeOptions == Shapes.Circle) {
            Instantiate(CircleSpawner);
        }
        else {
            Instantiate(TriangleSpawner);
        }
    }
}
