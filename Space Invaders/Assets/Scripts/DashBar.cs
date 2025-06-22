using UnityEngine;
using UnityEngine.UI;

public class DashBar : MonoBehaviour
{
    public GameObject ship;
    ShipMovement dashScript;
    Image image;
    float timer;
    float dashDelay;

    public Color unavailableColor;
    public Color availableColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dashScript = ship.GetComponent<ShipMovement>();
        image = GetComponent<Image>();
        dashDelay = dashScript.dashDelay;
    }

    // Update is called once per frame
    void Update()
    {
        timer = dashScript.dashTimer;
        if (timer < dashDelay)
        {
            image.fillAmount = timer / dashDelay;
            image.color = unavailableColor;
        }
        else
        {
            image.fillAmount = 1;
            image.color = availableColor;
        }
    }
}
