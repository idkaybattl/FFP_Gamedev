using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject alienManager;
    GameObject progress;
    ProgressScript progressScript;
    int enemyAmnt;
    int score = 0;

    public int health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyAmnt = alienManager.GetComponent<AlienSpawner>().alienAmnt;

        progress = GameObject.FindWithTag("Progress");
        progressScript = progress.GetComponent<ProgressScript>();
        progressScript.UpdateScore(0, enemyAmnt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore()
    {
        score = enemyAmnt;
        foreach (Transform alienFormation in alienManager.transform)
        {
            score -= alienFormation.childCount;
        }

        progressScript.UpdateScore(score, enemyAmnt);
    }

    public void RegisterHit(int hitImpact) {
        health -= hitImpact;
    }
}
