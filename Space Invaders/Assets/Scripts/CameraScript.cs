using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject ship;
    ShipMovement shipMovement;
    public float maxZoomOut;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shipMovement = ship.GetComponent<ShipMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float smth = shipMovement.velocity.magnitude * maxZoomOut / shipMovement.velocityCap;
    }
}
