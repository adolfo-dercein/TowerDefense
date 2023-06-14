
using UnityEngine;

namespace Assets._Code.Scripts.Enemy
{
    public abstract class EnemyBaseState
    {
        public abstract void EnterState(EnemyController enemyController);
        public virtual void UpdateState(EnemyController enemyController) { }
        public virtual void OnCollisionEnter(EnemyController enemyController, Collision2D collision) { }
        public virtual void OnTriggerEnter(EnemyController enemyController, Collider collider) { }
    }
}
