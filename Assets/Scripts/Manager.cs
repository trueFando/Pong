using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform ballSpawn;

    private Ball existingBall;

    private void Start()
    {
        StartNewRound();
    }

    public void StartNewRound()
    {
        if (existingBall != null) Destroy(existingBall.gameObject);
        existingBall = Instantiate(ballPrefab, ballSpawn.position, Quaternion.identity).GetComponent<Ball>();
    }
}
