using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int humanScore = 0;
    private int aiScore = 0;

    [SerializeField] private Text humanScoreText;
    [SerializeField] private Text aiScoreText;

    private Manager manager;

    private void Start()
    {
        manager = FindObjectOfType<Manager>();
    }

    public void ResetScores()
    {
        humanScore = 0;
        aiScore = 0;
        UpdateUI();
        manager.StartNewRound();
    }

    public void IncreaseScoreOnScoringPlayer(PlayerType scoringPlayer)
    {
        if (scoringPlayer == PlayerType.Human) IncreaseScore(ref humanScore);
        else IncreaseScore(ref aiScore);
    }

    private void IncreaseScore(ref int score)
    {
        score++;
        UpdateUI();
        manager.StartNewRound();
    }

    private void UpdateUI()
    {
        humanScoreText.text = humanScore.ToString();
        aiScoreText.text = aiScore.ToString();
    }
}
