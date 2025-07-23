using System.Threading;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public float Timer = 0f; 
    public bool attacking = false;
    public DetectorZone AttackZone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            attacking = true;
        }

        if (attacking == true)
        {
            Timer += Time.deltaTime;
            if (Timer >= 1f)
            {
                if (AttackZone.detectedcollision.Count > 0)
                {
                    for (int i = 0; i < AttackZone.detectedcollision.Count; ++i)
                    {
                        AttackZone.detectedcollision[i].GetComponent<Enemy_orc_behavior>().takingDamage(50);
                    }
                }
                attacking = false;
                Timer = 0f;
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
