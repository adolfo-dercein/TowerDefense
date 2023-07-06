using Assets._Code.Scripts.Enemy;
using System.Collections;
using Assets._Code.Scripts.Towers.Bullet;
using Assets._Code.Scripts.Util;
using UnityEngine;

namespace Assets._Code.Scripts.Towers
{
    public class Turret : MonoBehaviour
    {
        [SerializeField] private CannonWeapon weapon;
        
        public void Initialize(EnemyProvider enemyProvider, EntityPool<BulletEntity> bulletPool) => 
            weapon.Initialize(enemyProvider, bulletPool);
    }
}