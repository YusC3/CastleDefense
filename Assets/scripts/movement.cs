using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed = 5f;
    float horizontal_input;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal_input = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(speed * horizontal_input, rb.linearVelocity.y);
    } 
}

