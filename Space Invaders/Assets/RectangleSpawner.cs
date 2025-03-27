using UnityEngine;

public class RectangleSpawner : MonoBehaviour
{
    public GameObject alienSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        alienSpawner = GameObject.FindWithTag("Alien Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
