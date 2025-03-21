using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float deadZone = -200;
    public float velocity;
    public PipeSpawnScript pipeSpawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pipeSpawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = pipeSpawner.pipeVelocity;
        transform.position = transform.position + (Vector3.left * velocity) * Time.deltaTime;
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter() {

    }
}
