using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Player Property")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpForce;

    private float currentPlayerSpeed;
    private Rigidbody2D rb;
    private bool groundCheck;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //�� �������� enum
        rb.velocity = new Vector2(currentPlayerSpeed * Time.deltaTime, rb.velocity.y); //Time.deltaTime??
    }



    public void RightMove()
    {
        currentPlayerSpeed = playerSpeed;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    public void LeftMove()
    {
        currentPlayerSpeed = -playerSpeed;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.y);
    }
    public void StopMove()
    {
        currentPlayerSpeed = 0f;
    }
    public void Jump()
    {

    }
}