using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootRate = 0.3f;
    float timer = 0;
    public GameObject laser;
    Transform ship;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = transform.Find("Ship").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > shootRate) {
            Instantiate(laser, ship.position, Quaternion.Euler(ship.localRotation.eulerAngles + new Vector3(0, 0, 90)), transform);
            timer = 0;
        } else {
            timer += Time.deltaTime;
        }
    }
}
