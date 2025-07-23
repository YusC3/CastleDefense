using System.Collections.Generic;
using UnityEngine;

public class HeroAttackZone : MonoBehaviour
{
    public List<Enemy_orc_behavior> detectedcollision = new List<Enemy_orc_behavior>();
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        detectedcollision.Add(collision.GetComponent<Enemy_orc_behavior>());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        detectedcollision.Remove(collision.GetComponent<Enemy_orc_behavior>());
    }
}
