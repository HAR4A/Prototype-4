using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private GameObject[] powerupPrefabs;
    [SerializeField] private GameObject rocketBoosterPrefab;
    [SerializeField] private int enemyCount;
    [SerializeField] private int waveNumber = 1;
    private float spawnRange = 9.0f;
    private GameObject randomPrefab;

    void Start()
    {
        int randomPowerup = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[randomPowerup], GenerateSpawnPosition(), powerupPrefabs[randomPowerup].transform.rotation);
        SpawnEnemyWave(3);
    }
                    
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            int randomPowerup = Random.Range(0, powerupPrefabs.Length);
            Instantiate(powerupPrefabs[randomPowerup], GenerateSpawnPosition(), powerupPrefabs[randomPowerup].transform.rotation);

        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length);
        randomPrefab = enemyPrefab[randomIndex];

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(randomPrefab, GenerateSpawnPosition(), randomPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
