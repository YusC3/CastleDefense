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

    }

    public void TakeDamage()
    {
        HitPoint = HitPoint - 0.1f;
        HealthBar.sethealth(HitPoint, MaxHitPoint); 

        if (HitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }
}
