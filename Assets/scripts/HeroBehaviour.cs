using UnityEngine;

public class HeroBehaviour : MonoBehaviour
{
    public float HitPoint;
    public float MaxHitPoint;
    public HeroHealthBarBehaviour HealthBar;
    public float Death_animation_timer = 0f;
    private Animator animator;

    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        HitPoint = MaxHitPoint;
        HealthBar.sethealth(HitPoint, MaxHitPoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (HitPoint <= 0)
        {
            animator.SetTrigger("death");
            Death_animation_timer += Time.deltaTime;
            if (Death_animation_timer >= 2f)
            {
                Destroy(gameObject);
            }
        }
    }

    public void TakeDamage()
    {
        HitPoint = HitPoint - 0.1f;
        HealthBar.sethealth(HitPoint, MaxHitPoint); 
    }
}
