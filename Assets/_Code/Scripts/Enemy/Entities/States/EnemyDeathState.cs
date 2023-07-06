
namespace Assets._Code.Scripts.Enemy.Entities.States
{
    public class EnemyDeathState : EnemyBaseState
    {

        public override void EnterState(EnemyEntity enemyController)
        {
            enemyController.gameManagerController.AddEnemyKillCount();
            enemyController.gameManagerController.AddCoinCount();

            enemyController.DestroyGameObject();
            //TODO: play sound 
        }
    }
}
