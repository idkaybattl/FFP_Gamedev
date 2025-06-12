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
        if (Camera.main.orthographicSize - originalZoom < maxZoomOut * (shipMovement.velocity.magnitude / shipMovement.velocityCap))
        {
            Camera.main.orthographicSize = Mathf.Min(originalZoom + maxZoomOut, Camera.main.orthographicSize + zoomSpeed * Time.deltaTime);
        }
        else
        {
            Camera.main.orthographicSize = Mathf.Max(0, Camera.main.orthographicSize - zoomSpeed * Time.deltaTime);
        }

        Camera.main.transform.position = ship.transform.position + new Vector3(0,0,-5);
    }
}
