using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAIController : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    private Transform ball;
    private Camera mainCam;

    private float leftBound, rightBound;

    private void Start()
    {
        mainCam = Camera.main;
        SetBounds();
    }

    private void Update()
    {
        if (ball == null)
        {
            TryToFindBall();
            return;
        }

        Move();
    }

    private void TryToFindBall()
    {
        ball = FindObjectOfType<Ball>().transform;
    }

    private void SetBounds()
    {
        float boundOffset = 1f; // убрать магическое число
        leftBound = mainCam.ViewportToWorldPoint(new Vector3(0f, 0f)).x + boundOffset;
        rightBound = mainCam.ViewportToWorldPoint(new Vector3(1f, 0f)).x - boundOffset;
    }

    private void Move()
    {
        Vector3 movement = new Vector3(xSpeed * Time.deltaTime, 0f, 0f);
        Vector3 newPosition;

        if (ball.transform.position.x > transform.position.x) newPosition = transform.position + movement;
        else newPosition = transform.position - movement;

        newPosition.x = Mathf.Clamp(newPosition.x, leftBound, rightBound);
        transform.position = newPosition;
    }
}
