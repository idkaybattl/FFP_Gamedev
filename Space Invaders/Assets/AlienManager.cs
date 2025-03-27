using System;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public enum Shapes {
        Rectangle,
        Circle,
        Triangle
    }

    public Shapes shapeOptions;
    static Action[] spawnShapeActions;

    public GameObject alien;

    public int alienLevel;
    public Vector2 spawnDimensions;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnShapeActions = new Action[] {
            SpawnRectangle,
            SpawnCircle,
            SpawnTriangle
        };
        spawnShapeActions[(int) shapeOptions]();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRectangle()
    {
        int alienGridWidth = (int) ((alienLevel + 4) * 1.25);
        int alienGridHeight = (int) (alienGridWidth * spawnDimensions.y / spawnDimensions.x * 3);

        Debug.Log(new Vector2(alienGridWidth, alienGridHeight));
        Vector2 spawnDimensionOffset = spawnDimensions / 2;

        float x;
        float y;
        
        for (int i = 0; i < alienGridHeight; i++) {
            for (int j = 0; j < alienGridWidth; j++) {
                x = spawnDimensions.x * ((float) j / (alienGridWidth - 1)) - spawnDimensionOffset.x + transform.position.x;
                y = spawnDimensions.y * ((float) i / (alienGridHeight - 1)) - spawnDimensionOffset.y + transform.position.y;

                Instantiate(alien, new Vector3(x, y, 0), new Quaternion(), transform);
            }
        }
    }

    public static void SpawnCircle()
    {

    }

    public static void SpawnTriangle()
    {

    }
}
