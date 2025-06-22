using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject alienManager;
    GameObject progress;
    ProgressScript progressScript;
    int enemyAmnt;
    int score = 0;

    public int maxHealth;
    public int health;
    public GameObject healthBar;
    HealthBar healthBarScript;

    public GameObject ship;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyAmnt = alienManager.GetComponent<AlienSpawner>().alienAmnt;
        health = maxHealth;

        progress = GameObject.FindWithTag("Progress");
        progressScript = progress.GetComponent<ProgressScript>();
        progressScript.UpdateScoreText(0, enemyAmnt);

        healthBarScript = healthBar.GetComponent<HealthBar>();
        healthBarScript.Initialize(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHealth()
    {

    }

    public void UpdateScore()
    {
        score = enemyAmnt;
        foreach (Transform alienFormation in alienManager.transform)
        {
            score -= alienFormation.childCount;
        }

        progressScript.UpdateScoreText(score, enemyAmnt);

        if (score == enemyAmnt)
        {
            GameEnd(true);
        }
    }

    public void RegisterHit(int hitImpact)
    {
        health -= hitImpact;

        if (health <= 0)
        {
            GameEnd(false);
        }

        healthBarScript.UpdateHealthBar(health);
    }

    public void GameEnd(bool won)
    {
        Debug.Log("Died");
        ship.GetComponent<ShipMovement>().enabled = false;
        ship.GetComponent<Hook>().enabled = false;
        ship.GetComponent<Shooting>().enabled = false;
        ship.GetComponent<ShipCollisions>().enabled = false;

        if (won)
        {
            winScreen.SetActive(true);
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
    }
}
