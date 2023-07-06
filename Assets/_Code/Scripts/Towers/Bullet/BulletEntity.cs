using Assets._Code.Scripts.Enemy.Entities;
using Assets._Code.Scripts.Util;
using UnityEngine;

namespace Assets._Code.Scripts.Towers.Bullet
{
    public class BulletEntity : MonoBehaviour, PoolableEntity
    {
        [SerializeField] private LayerMask impactLayer;

        private float speed;
        public bool InUse { get; private set; }

        public void Initialize(Transform fireSpot, float bulletSpeed)
        {
            InUse = true;
            this.speed = bulletSpeed;

            transform.position = fireSpot.position;
            transform.rotation = fireSpot.rotation;
        }

        void FixedUpdate()
        {
            Move();
            AttemptImpact();
        }

        private void Move() => 
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        private void AttemptImpact()
        {
            RaycastHit hit;
            var lookAhead = speed * Time.fixedDeltaTime;
            var ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, lookAhead, impactLayer))
                OnImpact(hit.collider.GetComponent<EnemyEntity>());
        }

        public void OnImpact(EnemyEntity entityHit)
        {
            entityHit.ReceiveDamage();
            InUse = false;
            gameObject.SetActive(false);
        }
    }
}