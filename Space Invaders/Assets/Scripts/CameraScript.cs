using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject ship;
    ShipMovement shipMovement;
    public float zoomSpeed;
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
        // if below maxzoomout * (shipspeed/shipmaxspeed), zoom out by zoomspeed, else reduce zoom by zoomspeed
        Camera.main.orthographicSize = originalZoom + shipMovement.velocity.magnitude * maxZoomOut / shipMovement.velocityCap;
    }
}
