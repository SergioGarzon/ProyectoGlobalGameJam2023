using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float forceMovement = 1f;

    private Rigidbody2D body;

    private Vector2 playerPosition;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
       

        //body.AddForce(new Vector2(10f, 45f), ForceMode2D.Impulse);
    }


    private void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        playerPosition = transform.position;

        playerPosition = playerPosition + new Vector2(movementX, 0f) * forceMovement * Time.deltaTime;

        transform.position = playerPosition;

        StartCoroutine(MovementGravity());

        Debug.Log("Eje x: " + transform.position.x + ", eje y: " + transform.position.y);
    }
    
    IEnumerator MovementGravity()
    {
        yield return new WaitForSeconds(5f);
    }

}
