using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        Vector3 startForce = FindObjectOfType<PlatformHumanController>().transform.position - transform.position;
        GetComponent<Rigidbody2D>().AddForce(startForce * speed, ForceMode2D.Impulse);
    }
}
