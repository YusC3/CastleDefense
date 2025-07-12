using UnityEngine;

public class enemy_orc_behavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}
