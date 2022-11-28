using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 startForce = FindObjectOfType<PlatformHumanController>().transform.position - transform.position;
        rb.AddForce(startForce * speed, ForceMode2D.Impulse);
    }

}
