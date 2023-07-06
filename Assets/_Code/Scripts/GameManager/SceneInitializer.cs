using System.Collections;
using Assets._Code.Scripts.Enemy;
using Assets._Code.Scripts.Player;
using Assets._Code.Scripts.Towers;
using Assets._Code.Scripts.Towers.Bullet;
using Assets._Code.Scripts.Util;
using UnityEngine;

namespace Assets._Code.Scripts.GameManager
{
    public class SceneInitializer : MonoBehaviour
    {
        [SerializeField] private EnemySpawner enemySpawner;
        [SerializeField] private PlayerInitializer playerInitializer;
        [SerializeField] private BulletEntity bulletPrefab;
        [SerializeField] private Transform bulletContainer;

        void Start()
        {
            var enemyProvider = new EnemyProvider();
            var bulletPool = new EntityPool<BulletEntity>(bulletPrefab, bulletContainer);

            enemySpawner.Initialize(enemyProvider);
            playerInitializer.Initialize(enemyProvider, bulletPool);
        }
    }
}