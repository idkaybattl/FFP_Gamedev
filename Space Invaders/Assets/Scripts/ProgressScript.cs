using UnityEngine;
using TMPro;
using System;

public class ProgressScript : MonoBehaviour
{
    TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int score, int enemyAmnt)
    {
        scoreText.text = string.Format("{0,3}/{1}", score, enemyAmnt);
    }
}
