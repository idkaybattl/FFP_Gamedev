using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
{
    public GameState gameState;
    public TextMeshProUGUI levelText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelText.text = "Level " + gameState.level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
