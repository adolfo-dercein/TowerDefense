
namespace Assets._Code.Scripts.Enemy.States
{
    public class EnemyDeathState : EnemyBaseState
    {
        public override void EnterState(EnemyController enemyController)
        {
            enemyController.DestroyGameObject();
            //TODO: play sound 
        }
    }
}
