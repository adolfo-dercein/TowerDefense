using System.Collections;
using Assets._Code.Scripts.Enemy;
using Assets._Code.Scripts.Towers.Bullet;
using Assets._Code.Scripts.Util;
using UnityEngine;

namespace Assets._Code.Scripts.Towers
{
    public class CannonWeapon : MonoBehaviour
    {
        [SerializeField] Transform firePosition;
        [SerializeField] float cooldown;
        [SerializeField] float bulletSpeed;
        [SerializeField] float range;
        [SerializeField] float rotationSpeed;

        EntityPool<BulletEntity> bulletPool;
        bool canFire = true;
        EnemyProvider enemyProvider;
        Rotator rotator;

        public void Initialize(EnemyProvider enemyProvider, EntityPool<BulletEntity> bulletPool)
        {
            this.enemyProvider = enemyProvider;
            this.bulletPool = bulletPool;

            rotator = new Rotator(transform, rotationSpeed);
        }

        void FixedUpdate()
        {
            if (enemyProvider.IsEnemyInRange(transform.position, range))
            {
                var target = enemyProvider.GetClosestEnemyToPoint(transform.position, range);
                rotator.AimAt(target.transform.position);
                Fire();
            }
        }

        public void Fire()
        {
            if(canFire)
            {
                var bullet = bulletPool.PullEntity();
                bullet.Initialize(firePosition, bulletSpeed);
                StartCoroutine(StartCooldown());
            }
        }

        IEnumerator StartCooldown()
        {
            canFire = false;
            yield return new WaitForSeconds(cooldown);
            canFire = true;
        }
    }
}