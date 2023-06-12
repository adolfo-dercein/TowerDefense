
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    public GameObject enemy;
    private float spawnFrecuency = Parameters.EnemyParameters.SpawnFrecuency;
    public GameObject firstWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, spawnFrecuency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(enemy);
        newEnemy.GetComponent<EnemyController>().firstWaypoint = firstWaypoint;
    }
}
