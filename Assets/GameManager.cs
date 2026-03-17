using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private int score = 0;
    public float timer = 10;
    private bool gameOver = false;

    
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;
        UpdateScoreUI();
        UpdateTimerUI();
    }

    void Update()
    {
        if (gameOver)
            return;

        timer -= Time.deltaTime;

        if (timer < 0)
            timer = 0;

        UpdateTimerUI();
    }

    public void AddScore()
    {
        if (gameOver)
            return;

        score += 1;
        UpdateScoreUI();
    }

    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0f;
        Debug.Log("Game Over");
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.Ceil(timer);
        }
    }
}