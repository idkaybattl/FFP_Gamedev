using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject canvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowScreen(GameObject screen)
    {
        foreach (Transform child in canvas.transform)
        {
            child.gameObject.SetActive(false);
        }
        screen.SetActive(true);
    }
}
