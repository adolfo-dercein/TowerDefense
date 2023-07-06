using System.Collections;
using Assets._Code.Scripts.Enemy.Entities;
using Assets._Code.Scripts.Util.Parameters;
using UnityEngine;

namespace Assets._Code.Scripts.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] EnemyEntity enemyPrefab;
        EnemyProvider enemyProvider;

        public void Initialize(EnemyProvider enemyProvider)
        {
            this.enemyProvider = enemyProvider;
            InvokeRepeating("SpawnEnemy", 2, Parameters.EnemyParameters.SpawnFrequency);
        }

        void SpawnEnemy()
        {
            var spawnedEnemy = Instantiate(enemyPrefab, transform);
            enemyProvider.RegisterEnemy(spawnedEnemy);
        }
    }
}
