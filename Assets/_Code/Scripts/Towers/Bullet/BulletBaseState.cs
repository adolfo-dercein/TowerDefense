using UnityEngine;

namespace Assets._Code.Scripts.Towers.Bullet
{
    public abstract class BulletBaseState
    {
        public abstract void EnterState(BulletController bulletController);
        public virtual void UpdateState(BulletController bulletController) { }
        public virtual void OnCollisionEnter(BulletController bulletController, Collision2D collision) { }
        public virtual void OnTriggerEnter(BulletController bulletController, Collider other) { }
    }
}
