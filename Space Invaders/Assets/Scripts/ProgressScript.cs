using UnityEngine;
using TMPro;
using System;

public class ProgressScript : MonoBehaviour
{
    TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScoreText(int score, int enemyAmnt)
    {
        scoreText.text = string.Format("{0,3}/{1}", score, enemyAmnt);
    }
}
