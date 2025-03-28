using System;
using System.Xml.Schema;
using Random = UnityEngine.Random;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public enum Shapes {
        Rectangle,
        Ellipse,
        Triangle
    }

    public Shapes shapeOptions;
    static Action[] spawnShapeActions;

    public GameObject alien;
    public GameObject alienFormation;
    GameObject currentAlienFormation;

    public int alienLevel;
    public Vector2 spawnDimensions;


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

        spawnShapeActions = new Action[] {
            SpawnRectangle,
            SpawnEllipse,
            SpawnTriangle
        };
        spawnShapeActions[(int) shapeOptions]();
    }

    public void SpawnRectangle()
    {
        int alienGridWidth = (int) ((alienLevel + 4) * 1.25);
        int alienGridHeight = (int) (alienGridWidth * spawnDimensions.y / spawnDimensions.x * 3);

        Vector2 spawnDimensionOffset = spawnDimensions / 2;

        float x;
        float y;

        float maxAlienOffset = spawnDimensions.x / alienGridWidth / 2;
        
        for (int i = 0; i < alienGridHeight; i++) {
            for (int j = 0; j < alienGridWidth; j++) {
                x = spawnDimensions.x * ((float) j / (alienGridWidth - 1)) - spawnDimensionOffset.x + transform.position.x + Random.Range(0, maxAlienOffset) - maxAlienOffset / 2;
                y = spawnDimensions.y * ((float) i / (alienGridHeight - 1)) - spawnDimensionOffset.y + transform.position.y;

                Instantiate(alien, new Vector3(x, y, 0), new Quaternion(), currentAlienFormation.transform);
            }
        }
    }

    public void SpawnEllipse()
    {
        
    }

    public void SpawnTriangle()
    {

    }
}
