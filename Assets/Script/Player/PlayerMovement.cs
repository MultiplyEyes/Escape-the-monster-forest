using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D playerRB;
    

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    void FixedUpdate()
    {
        ProcessInput();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        playerRB.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
    }
}
