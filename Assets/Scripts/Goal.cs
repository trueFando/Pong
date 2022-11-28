using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private PlayerType playerTypeWhoAimsMe; // кто в эти ворота бьет
    private ScoreKeeper scoreKeeper;

    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>() != null)
        {
            scoreKeeper.IncreaseScoreOnScoringPlayer(playerTypeWhoAimsMe);
        }
    }
}
