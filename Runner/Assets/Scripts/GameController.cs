using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnTime;

    float m_spawnTime;
    int m_score;
    bool m_isGameover;

    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_score = 0;

        m_ui = FindAnyObjectByType<UIManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (m_isGameover)
        {
            m_spawnTime = 0;
            m_ui.showGameoverPanel(true);
            return;
        }

        if (m_spawnTime <= 0)
        {
            SpawnObstacle();
            m_spawnTime = spawnTime;
        }

    }


    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void IncrementScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }
    public void SpawnObstacle()
    {
        float posY = Random.Range(-3.5f, -2);
        Vector2 spawnPos = new Vector2(13.5f,posY);
        if (Obstacle)
        {
            Instantiate(Obstacle, spawnPos, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        m_score = value;
    }
    public int GetScore() { return m_score; }

    public void InCrementScore()
    {
        if (m_isGameover) return;

        m_score++;
    }

    public bool IsGameover()
    {
        return m_isGameover;
    }

    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }
}
