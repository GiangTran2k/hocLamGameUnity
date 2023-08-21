using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    public GameObject gameoverPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText != null)
        {
            scoreText.text = txt;
        }
    }

    public void showGameoverPanel(bool isShow)
    {
        if (gameoverPanel != null)
        {
            gameoverPanel.SetActive(isShow);
        }
    }
}
