using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject ship;
    Rigidbody2D shipRb;
    ShipMovement shipMovement;

    public float catchUpTime;
    Vector3 camVelocity;
    Vector3 targetPosition;
    public float offsetFactor;

    public float zoomCatchUpTime;
    public float maxZoomOut;
    float maxZoom;
    float originalZoom;
    float goalZoom;
    float maxSpeed;

    void Start()
    {
        shipRb = ship.GetComponent<Rigidbody2D>();
        shipMovement = ship.GetComponent<ShipMovement>();
        originalZoom = Camera.main.orthographicSize;

        maxSpeed = shipMovement.accelerationForce / (shipRb.linearDamping * shipRb.mass);
    }

    void LateUpdate()
    {
        targetPosition = ship.transform.position - offsetFactor * Vector3.ClampMagnitude(shipRb.linearVelocity, maxSpeed);
        targetPosition.z = Camera.main.transform.position.z;
        Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, targetPosition, ref camVelocity, catchUpTime);

        maxZoom = originalZoom + maxZoomOut;
        goalZoom = Mathf.Lerp(originalZoom, maxZoom, Mathf.Min(shipRb.linearVelocity.magnitude / maxSpeed, 1));
        Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, goalZoom, Time.deltaTime / zoomCatchUpTime);
    }
}
