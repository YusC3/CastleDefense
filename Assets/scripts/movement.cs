using System; 
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 5f;
    float horizontal_input;
    bool isFacingRight = false;

    Rigidbody2D rd;
    Animator animator;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal_input = Input.GetAxis("Horizontal");
        FlipSprite();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(speed * horizontal_input, rb.linearVelocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.linearVelocity.x));
        //animator.SetFloat("xVelocity", rb.velocity.y); ALEX: TO DO
    }

    void FlipSprite()
    {
        if (isFacingRight && horizontal_input < 0f || !isFacingRight && horizontal_input > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}

