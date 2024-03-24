using UnityEngine;

public class AsteroidRain : MonoBehaviour
{
    public GameObject asteroidPrefab; // Prefab do asteroide
    public float timeBetweenSpawns = 2f; // Intervalo de tempo em segundos entre cada geração de asteroide
    public float spawnRadius = 5f; // Raio de spawn dos asteroides

    public float nextSpawnTime = 0; // Próximo momento em que um asteroide será spawnado

    void Update()
    {
        if (nextSpawnTime > timeBetweenSpawns)
        {
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            spawnPosition.z = 0f;
            GameObject newAsteroid = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
            nextSpawnTime = 0;
        }
        nextSpawnTime++;
    }
}
