using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject breakablePlatformPrefab;
    public GameObject deadPlatformPrefab;

    public float spawnDelay = 0.8f;
    public float minX = -2.5f;
    public float maxX = 2.5f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnDelay)
        {
            SpawnPlatform();
            timer = 0f;
        }
    }

    void SpawnPlatform()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(minX, maxX);

        int chance = Random.Range(0, 100);

        if (chance < 70)
        {
            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
        else if (chance < 90)
        {
            Instantiate(breakablePlatformPrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            Instantiate(deadPlatformPrefab, spawnPos, Quaternion.identity);
        }
    }
}
