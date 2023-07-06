
namespace Assets._Code.Scripts.Towers.Bullet.States
{
    public class BulletDestroyedState : BulletBaseState
    {
        public override void EnterState(BulletController bulletController)
        {
            bulletController.DestroyGameObject();
        }
    }
}
