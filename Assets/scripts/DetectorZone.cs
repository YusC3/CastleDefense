using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<Collider2D> detectedcollision = new List<Collider2D>();
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        detectedcollision.Add(collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        detectedcollision.Remove(collision);
    }

    // Update is called once per frame

}
