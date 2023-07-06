
using UnityEngine;

namespace Assets._Code.Scripts.Enemy.Entities
{
    public abstract class EnemyBaseState
    {
        public abstract void EnterState(EnemyEntity enemyController);
        public virtual void UpdateState(EnemyEntity enemyController) { }
        public virtual void OnCollisionEnter(EnemyEntity enemyController, Collision2D collision) { }
        public virtual void OnTriggerEnter(EnemyEntity enemyController, Collider collider) { }
    }
}
