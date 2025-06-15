using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject ship;
    Rigidbody2D shipRb;
    ShipMovement shipMovement;

    public float catchUpTime;

    public float zoomCatchUpTime;
    public float maxZoom;
    float originalZoom;
    float goalZoom;
    float maxSpeed;

    float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shipRb = ship.GetComponent<Rigidbody2D>();
        shipMovement = ship.GetComponent<ShipMovement>();
        originalZoom = Camera.main.orthographicSize;

        maxSpeed = shipMovement.accelerationForce / shipRb.linearDamping;
    }

    // Update is called once per frame
    void Update()
    {
        // distance = new Vector2(Camera.main.transform.position.x - ship.transform.position.x, Camera.main.transform.position.y - ship.transform.position.y).magnitude;
        // if (distance > 0.05f)
        // {
        //     Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, ship.transform.position - new Vector3(0, 0, 5), Time.deltaTime / catchUpTime);
        // }
        // else
        // {
        //     Camera.main.transform.position = ship.transform.position - new Vector3(0,0,5);
        // }
        //
        // goalZoom = Mathf.Lerp(originalZoom, maxZoom, Mathf.Min(shipRb.linearVelocity.magnitude / maxSpeed, 1));
        // Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, goalZoom, Time.deltaTime / zoomCatchUpTime);
    }
}
