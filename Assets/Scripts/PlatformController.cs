using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // speed on X axis
    [SerializeField] protected float xSpeed;

    // cam for setting of bounds (using viewport)
    protected Camera mainCam;
    protected float leftBound, rightBound;

    protected void Start()
    {
        mainCam = Camera.main;
        SetBounds();
    }

    protected void SetBounds()
    {
        float boundOffset = 1f; // убрать магическое число
        leftBound = mainCam.ViewportToWorldPoint(new Vector3(0f, 0f)).x + boundOffset;
        rightBound = mainCam.ViewportToWorldPoint(new Vector3(1f, 0f)).x - boundOffset;
    }

    protected void Move(bool right) // if right then move right, else move left
    {
        Vector3 movement = new Vector3(xSpeed * Time.deltaTime, 0f, 0f);
        Vector3 newPosition;

        if (right) newPosition = transform.position + movement;
        else newPosition = transform.position - movement;

        newPosition.x = Mathf.Clamp(newPosition.x, leftBound, rightBound);
        transform.position = newPosition;
    }
}
