using UnityEngine;

public class PlatformAIController : PlatformController
{
    private Transform ball;

    private void Update()
    {
        // if ball has been destroyed 
        if (ball == null)
        {
            TryToFindBall();
            return;
        }

        if (ball.transform.position.y > center.y)
        {
            // follow the ball on X axis
            Move(ball.transform.position.x > transform.position.x);
        }
    }

    private void TryToFindBall()
    {
        ball = FindObjectOfType<Ball>().transform;
    }
}
