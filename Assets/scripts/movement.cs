using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 5f;
    float horizontal_input;

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
        if (horizontal_input == 0f) {return;};
        Vector3 ls = transform.localScale;
        if (horizontal_input < 0f)
            { ls.x = Math.Abs(ls.x) * -1; }
        else 
            { ls.x = Math.Abs(ls.x); }
        transform.localScale = ls;
    }
}

