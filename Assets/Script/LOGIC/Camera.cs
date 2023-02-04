using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject playerRoot;
    public float smoothing;

    Vector2 velocity;

    private float position;

    private void Start()
    {
        position = 484.48f;
    }


    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, playerRoot.transform.position.y - transform.position.y, transform.position.z);

    }
}
