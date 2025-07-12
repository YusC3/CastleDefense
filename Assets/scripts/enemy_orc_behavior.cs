using UnityEngine;

public class Enemy_orc_behavior : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2f;
    public int damage = 10;
    public DetectorZone AttackZone;
    public int health = 50;
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
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        timer += Time.deltaTime;
        if (target == null || timer <= 2)
        {
            animator.SetFloat("Xvelocity", 0);
        }
        else if (AttackZone.detectedcollision.Count > 0)
        {
            animator.SetBool("in_range", true);
            transform.position = transform.position;
        }
        else
        {
            animator.SetBool("in_range", false);
            animator.SetFloat("Xvelocity", 2f);
            transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
        }
    }
    public void takingDamage(int amount)
    {
        health -= amount;
    }
}
