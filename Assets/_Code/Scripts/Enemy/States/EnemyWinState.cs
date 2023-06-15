

namespace Assets._Code.Scripts.Enemy.States
{
    public class EnemyWinState : EnemyBaseState
    {
        public override void EnterState(EnemyController enemyController)
        {
            enemyController.gameManagerController.AddEnemyPassCount();

            // TODO: remove life form "player" 
            // TODO: Add enemy wins to counter             
        }
    }
}
