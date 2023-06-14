
namespace Assets._Code.Scripts.Tower.Bullet.States
{
    public class BulletDestroyedState : BulletBaseState
    {
        public override void EnterState(BulletController bulletController)
        {
            bulletController.DestroyGameObject();
        }
    }
}
