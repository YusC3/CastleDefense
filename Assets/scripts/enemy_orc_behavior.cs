using UnityEngine;
using System;

public class Enemy_orc_behavior : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2f;
    public int damage = 10;
    public DetectorZone AttackZone;
    public int health = 50;
    public Transform target;
    public HeroBehaviour HeroB;

    private float timer = 0f;
    private Animator animator;

    //Ore Hit Hero
    private bool HitProcess = false;
    private float hitTime = 0f;
    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("in_range", false);
    }
    void Update()
    {
        if (HitProcess)
        {
            hitTime += Time.deltaTime;

            if (hitTime >= 0.4f && hitTime <= 0.415f)
            {
                HeroB.TakeDamage();
            }
            if (hitTime >= 1f)
            {
                hitTime = 0f;
                HitProcess = false;
            }     
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        timer += Time.deltaTime;

        if (target == null)
        {
            animator.SetFloat("speed", 0);
            animator.SetBool("in_range", false);
        }
        else
        {
            if (AttackZone.detectedcollision.Count > 0)
            {
                animator.SetBool("in_range", true);
                transform.position = transform.position;
                HitProcess = true;
            }
            else
            {
                animator.SetBool("in_range", false);
                animator.SetFloat("speed", speed);
                transform.position = Vector2.MoveTowards(
                transform.position,
                target.position,
                speed * Time.deltaTime
                );
            }
            Vector3 ls = transform.localScale;
            if (transform.position.x < target.position.x)
            { ls.x = Math.Abs(ls.x) * -1; }
            else { ls.x = Math.Abs(ls.x); }
            transform.localScale = ls;

        }
    }
    public void takingDamage(int amount)
    {
        health -= amount;
    }
}
