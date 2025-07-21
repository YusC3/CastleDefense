using UnityEngine;

public class Spawn_New_Orc : MonoBehaviour
{
    public GameObject OrcPrefab;
    public float SpawnInterval = 10f;

    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawning();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > SpawnInterval)
        {
            spawning();
            timer = 0f;
        }
    }

    void spawning()
    {
        GameObject clone = Instantiate(OrcPrefab, new Vector3(8.32f, -1.6f, 0f), Quaternion.identity);
        clone.SetActive(true);
    }
}
