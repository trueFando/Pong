using UnityEngine;

public class PlatformAIController : PlatformController
{
    private Transform ball;

    private void Update()
    {
        if (ball == null)
        {
            TryToFindBall();
            return;
        }

        // follow the ball on X axis
        Move(ball.transform.position.x > transform.position.x);
    }

    private void TryToFindBall()
    {
        ball = FindObjectOfType<Ball>().transform;
    }
}
