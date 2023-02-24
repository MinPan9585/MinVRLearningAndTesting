using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private float gameTime;
    private float sliderCurrentFillAmount = 1f;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int playerScore;

    private void Update()
    {
        AdjustTimer();
    }

    void AdjustTimer()
    {
        timerImage.fillAmount = sliderCurrentFillAmount - Time.deltaTime/gameTime;
        sliderCurrentFillAmount = timerImage.fillAmount;
    }

    public void UpdatePlayerScore(int hitPoints)
    {
        playerScore += hitPoints;
        scoreText.text = playerScore.ToString();
    }
}
