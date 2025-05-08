using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootRate = 0.3f;
    float timer = 0;
    public GameObject laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > shootRate) {
            Instantiate(laser, transform.position, transform.rotation, transform.parent);
            timer = 0;
        } else {
            timer += Time.deltaTime;
        }
    }
}
