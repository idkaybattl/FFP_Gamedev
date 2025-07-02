using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameState gameState;
    public GameState maxStats;
    public GameState minStats;

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
        gameState
    }

    void Start()
    {
        enemyAmnt = alienManager.GetComponent<AlienSpawner>().alienAmnt;
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

    public void UpdateScore()
    {
        score = enemyAmnt + 1;
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
}
