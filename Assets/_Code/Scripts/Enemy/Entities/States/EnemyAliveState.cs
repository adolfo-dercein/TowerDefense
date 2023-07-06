using Assets._Code.Scripts.Util;
using Assets._Code.Scripts.Util.Parameters;
using UnityEngine;

namespace Assets._Code.Scripts.Enemy.Entities.States
{
    public class EnemyAliveState : EnemyBaseState
    {
        public GameObject firstWaypoint;
        public Vector3 direction;
         
        private float speed;
        private float minSpeed = Parameters.EnemyParameters.MinSpeed;
        private float maxSpeed = Parameters.EnemyParameters.MaxSpeed;

        private float health = Parameters.EnemyParameters.InitialHealth;

        public override void EnterState(EnemyEntity enemyController)
        {
            speed = Random.Range(minSpeed, maxSpeed);
            direction = Vector3.forward; // (firstWaypoint.transform.position - enemyController.transform.position).normalized;
        }

        public override void UpdateState(EnemyEntity enemyController)
        {
            enemyController.transform.Translate(direction * speed * Time.deltaTime);

            if (enemyController.transform.position.z > Parameters.EnemyParameters.LimitToDestroy)
            {
                enemyController.SwitchState(enemyController.DeathState);
            }
        }

        public override void OnTriggerEnter(EnemyEntity enemyController, Collider other)
        {
            if(other.CompareTag(Tags.Bullet))
            {
                health--;
                if (health <= 0)
                {
                    enemyController.SwitchState(enemyController.DeathState);
                }
            }
        }
    }
}
