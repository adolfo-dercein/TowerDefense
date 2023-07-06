

namespace Assets._Code.Scripts.Enemy.Entities.States
{
    public class EnemyWinState : EnemyBaseState
    {
        public override void EnterState(EnemyEntity enemyController)
        {
            enemyController.gameManagerController.AddEnemyPassCount();

            // TODO: remove life form "player" 
            // TODO: Add enemy wins to counter             
        }
    }
}
