using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject ship;
    ShipMovement shipMovement;
    public float zoomSpeed;
    public float zoomRecovery;
    public float maxZoomOut;
    float originalZoom;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shipMovement = ship.GetComponent<ShipMovement>();
        originalZoom = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.orthographicSize = originalZoom + shipMovement.velocity.magnitude * maxZoomOut / shipMovement.velocityCap;
    }
}
