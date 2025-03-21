using System;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float pipeDistance = 1500;
    public float pipeStartingVelocity = 30;
    public float pipeVelocity;
    public float pipeAcceleration = 0.1f;
    public float pipeVelocityCap = 200;
    public float spawnRate;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        pipeVelocity = pipeStartingVelocity;
        Spawnpipe();
    }

    // Update is called once per frame
    void Update() {
        if (pipeVelocity < pipeVelocityCap) {
            pipeVelocity += pipeAcceleration * Time.deltaTime;
        }
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        }
        else {
            Spawnpipe();
            spawnRate = (-pipeVelocity + Mathf.Sqrt(pipeVelocity 
                * pipeVelocity + 2 * pipeAcceleration * pipeDistance) ) / 2;
            timer = 0;
        }
    }
    void Spawnpipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}   
