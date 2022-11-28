using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        // find the point in world to push the ball (bottom center of the viewport)
        Vector3 viewportStartPoint = new Vector3(0.5f, 0f, 0f);
        Vector3 startPoint = Camera.main.ViewportToWorldPoint(viewportStartPoint);

        // push the ball to this point
        GetComponent<Rigidbody2D>().AddForce((startPoint - transform.position) * speed, ForceMode2D.Impulse);
    }
}
