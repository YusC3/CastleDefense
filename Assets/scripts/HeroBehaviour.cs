using UnityEngine;

public class HeroBehaviour : MonoBehaviour
{
    public float HitPoint;
    public float MaxHitPoint = 5;
    public HeroHealthBarBehaviour HealthBar;

    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HitPoint = MaxHitPoint;
        HealthBar.sethealth(HitPoint, MaxHitPoint);
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.016f;
        if (timer >= 1)
        {
            HitPoint = HitPoint - 0.1f;
            HealthBar.sethealth(HitPoint, MaxHitPoint);
            timer = 0;

            if (HitPoint <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
