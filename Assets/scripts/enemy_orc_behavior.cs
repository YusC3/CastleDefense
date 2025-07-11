using UnityEngine;

public class Enemy_orc_behavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2f;
    public Transform target;
    private float timer = 0f;
    private Animator animator;
    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (target == null || timer <= 2)
        {
            animator.SetFloat("Xvelocity", 0);
        }
        else
        {
            animator.SetFloat("Xvelocity", 2f);
            transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
        }
    }
}
