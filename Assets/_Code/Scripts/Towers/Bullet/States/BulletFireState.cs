using Assets._Code.Scripts.Util;
using Assets._Code.Scripts.Util.Parameters;
using UnityEngine;

namespace Assets._Code.Scripts.Towers.Bullet.States
{
    public class BulletFireState : BulletBaseState
    {
        private float speed = Parameters.BulletParameters.Speed;

        public override void EnterState(BulletController bulletController)
        {
            bulletController.shootSFX.Play();
            bulletController.gameObject.transform.position = bulletController.initialPos;
            // //gameObject.transform.rotation = direction;
            bulletController.gameObject.transform.LookAt(bulletController.target.transform.position);
        }

        public override void UpdateState(BulletController bulletController)
        {
            bulletController.transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (bulletController.transform.position.x > Parameters.BulletParameters.PositionOutsideArenaPos || 
                bulletController.transform.position.x < Parameters.BulletParameters.PositionOutsideArenaNeg || 
                bulletController.transform.position.z > Parameters.BulletParameters.PositionOutsideArenaPos || 
                bulletController.transform.position.z < Parameters.BulletParameters.PositionOutsideArenaNeg)
            {
                bulletController.SwitchState(bulletController.DestroyedState);
            }
        }

        public override void OnTriggerEnter(BulletController bulletController, Collider other)
        {
            if(other.CompareTag(Tags.Enemy))
            {
                bulletController.SwitchState(bulletController.DestroyedState);
            }
        }
    }
}
