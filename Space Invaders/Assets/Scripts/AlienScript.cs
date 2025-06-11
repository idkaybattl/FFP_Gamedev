using UnityEngine;

public class AlienScript : MonoBehaviour
{
    GameObject ship;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (ship.transform.position - transform.position).normalized * speed * Time.deltaTime;
    }
}
