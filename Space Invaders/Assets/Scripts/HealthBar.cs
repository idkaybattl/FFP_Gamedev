using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject live;
    public Sprite negative;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize(int maxHealth)
    {
        foreach (Transform live in transform)
        {
            Destroy(live);
        }
        for (int i = 0; i < maxHealth; i++)
        {
            Instantiate(live, transform);
        }
    }

    public void UpdateHealthBar(int health)
    {
        for (int i = health; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<Image>().overrideSprite = negative;
        }
    }
}
