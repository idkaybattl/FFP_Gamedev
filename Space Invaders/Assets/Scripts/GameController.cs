using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameState gameState;
    public GameState maxStats;
    public GameState minStats;

    public float statGrowthRate;

    public GameObject alienManager;
    public GameObject progress;
    ProgressScript progressScript;
    int enemyAmnt;
    int score = 0;

    int maxHealth;
    public int health;
    public GameObject healthBar;
    HealthBar healthBarScript;

    public GameObject ship;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    bool paused;

    InputAction pauseAction;
    bool pause;
    public GameObject pauseScreen;
    float pauseTimer;
    public float pauseDelay;

    public InputActionAsset inputAsset;
    InputActionMap gamePlayMap;

    void Awake()
    {
        gameState.shipAcceleration = InterpolateStat(minStats.shipAcceleration, maxStats.shipAcceleration, statGrowthRate, gameState.level);
        gameState.shipRotation = InterpolateStat(minStats.shipRotation, maxStats.shipRotation, statGrowthRate, gameState.level);
        gameState.dashForce = InterpolateStat(minStats.dashForce, maxStats.dashForce, statGrowthRate, gameState.level);
        gameState.dashDelay = InterpolateStat(minStats.dashDelay, maxStats.dashDelay, statGrowthRate, gameState.level);
        gameState.dashITime = InterpolateStat(minStats.dashITime, maxStats.dashITime, statGrowthRate, gameState.level);
        gameState.hitITime = InterpolateStat(minStats.hitITime, maxStats.hitITime, statGrowthRate, gameState.level);
        gameState.shootRate = InterpolateStat(minStats.shootRate, maxStats.shootRate, statGrowthRate, gameState.level);
        gameState.hookForce = InterpolateStat(minStats.hookForce, maxStats.hookForce, statGrowthRate, gameState.level);
        gameState.maxHealth = (int)Mathf.Lerp(minStats.maxHealth, maxStats.maxHealth, gameState.level / 100);
        gameState.alienAmnt = (int)Mathf.Lerp(minStats.alienAmnt, maxStats.alienAmnt, gameState.level / 100);
        gameState.alienSpawnTime = InterpolateStat(minStats.alienSpawnTime, maxStats.alienSpawnTime, statGrowthRate, gameState.level);
        gameState.alienAcceleration = InterpolateStat(minStats.alienAcceleration, maxStats.alienAcceleration, statGrowthRate, gameState.level);
        gameState.alienHealth = (int)Mathf.Lerp(minStats.alienHealth, maxStats.alienHealth, gameState.level / 100);
        gameState.alienHitImpact = (int)Mathf.Lerp(minStats.alienHitImpact, maxStats.alienHitImpact, gameState.level / 100);
    }

    void Start()
    {
        enemyAmnt = gameState.alienAmnt;
        maxHealth = gameState.maxHealth;
        health = maxHealth;

        progress = GameObject.FindWithTag("Progress");
        progressScript = progress.GetComponent<ProgressScript>();
        progressScript.UpdateScoreText(0, enemyAmnt);

        healthBarScript = healthBar.GetComponent<HealthBar>();
        healthBarScript.Initialize(maxHealth);

        pauseAction = inputAsset.FindAction("Pause");

        gamePlayMap = inputAsset.FindActionMap("Player");
    }

    // Update is called once per frame
    void Update()
    {
        pause = pauseAction.ReadValue<float>() > 0;
        if (pause && pauseTimer > pauseDelay)
        {
            TogglePause();
            pauseTimer = 0;
        }
        pauseTimer += Time.unscaledDeltaTime;
    }

    float InterpolateStat(float min, float max, float growthRate, int level)
    {
        float interpolationFactor = 1 - Mathf.Exp(-growthRate * level);
        return Mathf.Lerp(min, max, interpolationFactor);
    }

    public void UpdateScore()
    {
        score++;

        progressScript.UpdateScoreText(score, enemyAmnt);

        int currentEnemyAmnt = 0;
        foreach (Transform alienFormation in alienManager.transform)
        {
            currentEnemyAmnt += alienFormation.childCount;
        }

        if (score == enemyAmnt || currentEnemyAmnt == 0)
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
            gameState.level++;
            winScreen.SetActive(true);
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void TogglePause()
    {
        if (paused)
        {
            Unpause();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
        paused = true;
        gamePlayMap.Disable();
    }

    public void Unpause()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        paused = false;
        gamePlayMap.Enable();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
}
