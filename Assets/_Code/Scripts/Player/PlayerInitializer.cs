using System.Collections.Generic;
using Assets._Code.Scripts.Enemy;
using Assets._Code.Scripts.Towers;
using Assets._Code.Scripts.Towers.Bullet;
using Assets._Code.Scripts.Util;
using UnityEditor;
using UnityEngine;

namespace Assets._Code.Scripts.Player
{
    public class PlayerInitializer : MonoBehaviour
    {
        [SerializeField] Turret[] towers;

        public void Initialize(EnemyProvider enemyProvider, EntityPool<BulletEntity> bulletPool)
        {
            foreach (var t in towers)
                t.Initialize(enemyProvider, bulletPool);
        }
    }
}