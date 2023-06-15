
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    public GameObject enemy;
    private float spawnFrecuency;
    public GameObject firstWaypoint;

    void Start()
    {
        spawnFrecuency = Parameters.EnemyParameters.SpawnFrecuency;
        InvokeRepeating("SpawnEnemy", 2, spawnFrecuency);
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, transform);
    }
}
